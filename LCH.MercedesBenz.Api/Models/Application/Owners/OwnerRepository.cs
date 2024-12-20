using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Owners.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Owners
{
    public class OwnerRepository : BaseRepository<Owner>, IOwnerRepository
    {
        private readonly IMapper _mapper;
        public OwnerRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context) 
        {
            _mapper = mapper;
        }

        public BaseResponse<OwnerDto> GetAll2()
        {
            try
            {
                var results = Context.Owners.Select(i => new OwnerDto
                {
                    Id = i.Id,
                    FullName = i.FullName,
                    CUIT = i.CUIT,
                    CuitPref = i.CuitPref
                }).OrderBy(i => i.FullName).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<OwnerDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<OwnerDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Owner> Create(OwnerDto dto)
        {
            try
            {
                var entity = Context.Owners.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<Owner>(StatusCodes.Status400BadRequest, $"La entidad ya existe.");
                entity = _mapper.Map<Owner>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Owner>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Owner>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Owner> Update(OwnerDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Owner>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Owners.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Owner>(StatusCodes.Status400BadRequest, $"Id de entidad no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Owner>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Owner>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
