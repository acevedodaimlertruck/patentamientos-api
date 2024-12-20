using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos; 
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions.Dtos; 

namespace LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions
{
    public class Cat_InternalVersionRepository : BaseRepository<Cat_InternalVersion>, ICat_InternalVersionRepository
    {
        private readonly IMapper _mapper;

        public Cat_InternalVersionRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<Cat_InternalVersionDto> GetAll2()
        {
            try
            {
                var results = Context.Cat_InternalVersions.Select(i => new Cat_InternalVersionDto
                {
                    Id = i.Id,
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            TerminalId = i.CarModel.Brand.TerminalId,
                            Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                            {
                                Id = i.CarModel.Brand.Terminal.Id,
                                Name = i.CarModel.Brand.Terminal.Name
                            }
                        }
                    },
                    MercedesMarcaId = i.MercedesMarcaId,
                    MercedesModeloId = i.MercedesModeloId,
                    MercedesTerminalId = i.MercedesTerminalId,
                    Version = i.Version,
                    Description = i.Description,
                     DateTo = i.DateTo,
                    DateFrom = i.DateFrom
                }).OrderBy(i => i.Version).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<Cat_InternalVersionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Cat_InternalVersionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Cat_InternalVersion> Create(Cat_InternalVersionDto dto)
        {
            try
            {
                var entity = Context.Cat_InternalVersions.FirstOrDefault(p => p.CarModelId!.Equals(dto.CarModelId) && p.Version!.Equals(dto.Version)); 
                if (entity != null)
                    return new BaseResponse<Cat_InternalVersion>(StatusCodes.Status400BadRequest, $"Esta Versión Interna ya existe.");
                entity = _mapper.Map<Cat_InternalVersion>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Cat_InternalVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Cat_InternalVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Cat_InternalVersion> Update(Cat_InternalVersionDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Cat_InternalVersion>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Cat_InternalVersions.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Cat_InternalVersion>(StatusCodes.Status400BadRequest, $"Id de Version Interna no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<Cat_InternalVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Cat_InternalVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<int> GetLastId()
        {
            try
            {
                var results = Context.Cat_InternalVersions.AsEnumerable().Select(iv => int.TryParse(iv.Version, out var intValue) ? intValue : -1).Max();
                return new BaseResponse<int>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<int>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


    }
}
