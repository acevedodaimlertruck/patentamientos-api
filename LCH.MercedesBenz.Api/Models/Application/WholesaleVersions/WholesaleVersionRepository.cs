using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos; 
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions.Dtos; 

namespace LCH.MercedesBenz.Api.Models.Application.WholesaleVersions
{
    public class WholesaleVersionRepository : BaseRepository<WholesaleVersion>, IWholesaleVersionRepository
    {
        private readonly IMapper _mapper;

        public WholesaleVersionRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<WholesaleVersionDto> GetAll2()
        {
            try
            {
                var results = Context.WholesaleVersions.Select(i => new WholesaleVersionDto
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
                    Description = i.Description
                }).OrderBy(i => i.Version).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<WholesaleVersionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<WholesaleVersionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<WholesaleVersion> Create(WholesaleVersionDto dto)
        {
            try
            {
                var entity = Context.WholesaleVersions.FirstOrDefault(p => p.CarModelId!.Equals(dto.CarModelId) && p.Version!.Equals(dto.Version)); 
                if (entity != null)
                    return new BaseResponse<WholesaleVersion>(StatusCodes.Status400BadRequest, $"Esta Versión de Wholesale ya existe.");
                entity = _mapper.Map<WholesaleVersion>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<WholesaleVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<WholesaleVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<WholesaleVersion> Update(WholesaleVersionDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<WholesaleVersion>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.WholesaleVersions.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<WholesaleVersion>(StatusCodes.Status400BadRequest, $"Id de Versión WS no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<WholesaleVersion>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<WholesaleVersion>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                var results = Context.WholesaleVersions.AsEnumerable().Select(iv => int.TryParse(iv.Version, out var intValue) ? intValue : -1).Max();
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
