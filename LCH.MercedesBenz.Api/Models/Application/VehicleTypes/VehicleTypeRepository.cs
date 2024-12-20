using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;
using AutoMapper;

namespace LCH.MercedesBenz.Api.Models.Application.VehicleTypes
{
    public class VehicleTypeRepository : BaseRepository<VehicleType>, IVehicleTypeRepository
    {
        private readonly IMapper _mapper;
        public VehicleTypeRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context) 
        {
            _mapper = mapper;
        }

        public BaseResponse<VehicleTypeDto> GetAll2()
        {
            try
            {
                var results = Context.VehicleTypes.Select(i => new VehicleTypeDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                }).OrderBy(i => i.Name).ToList();
                return new BaseResponse<VehicleTypeDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<VehicleTypeDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<VehicleType> Create(VehicleTypeDto dto)
        {
            try
            {
                var entity = Context.VehicleTypes.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<VehicleType>(StatusCodes.Status400BadRequest, $"El tipo de vehículo ya existe.");
                entity = _mapper.Map<VehicleType>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<VehicleType>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<VehicleType>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<VehicleType> Update(VehicleTypeDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<VehicleType>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.VehicleTypes.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<VehicleType>(StatusCodes.Status400BadRequest, $"Id de tipo de vehículo no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<VehicleType>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<VehicleType>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
