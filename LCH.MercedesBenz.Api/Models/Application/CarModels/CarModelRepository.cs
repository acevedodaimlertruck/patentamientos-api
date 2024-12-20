using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CarModels
{
    public class CarModelRepository : BaseRepository<CarModel>, ICarModelRepository
    {
        private readonly IMapper _mapper;
        public CarModelRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context) 
        {
            _mapper = mapper;
        }

        public BaseResponse<CarModelDto> GetAll2()
        {
            try
            {
                var results = Context.CarModels.Select(i => new CarModelDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    BrandId = i.BrandId,
                    Brand = i.Brand == null ? null : new BrandDto
                    {
                        Id = i.Brand.Id,
                        Name = i.Brand.Name,
                        Description = i.Brand.Description,
                        TerminalId = i.Brand.TerminalId,
                        Terminal = i.Brand.Terminal == null ? null : new TerminalDto
                        {
                            Id = i.Brand.Terminal.Id,
                            Name = i.Brand.Terminal.Name,
                            Description = i.Brand.Terminal.Description,
                            MercedesTerminalId = i.Brand.Terminal.MercedesTerminalId
                        },
                        MercedesTerminalId = i.Brand.MercedesTerminalId,
                        MercedesMarcaId = i.Brand.MercedesMarcaId
                    },
                    MercedesTerminalId = i.MercedesTerminalId,
                    MercedesMarcaId = i.MercedesMarcaId,
                    MercedesModeloId = i.MercedesModeloId
                }).OrderBy(i => i.MercedesModeloId).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CarModelDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CarModelDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<CarModelDto> GetNoAssigned()
        {
            try
            {
                var result = Context.CarModels.Where(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033"))).Select(i => new CarModelDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    BrandId = i.BrandId,
                    Brand = i.Brand == null ? null : new BrandDto
                    {
                        Id = i.Brand.Id,
                        Name = i.Brand.Name,
                        Description = i.Brand.Description,
                        TerminalId = i.Brand.TerminalId,
                        Terminal = i.Brand.Terminal == null ? null : new TerminalDto
                        {
                            Id = i.Brand.Terminal.Id,
                            Name = i.Brand.Terminal.Name,
                            Description = i.Brand.Terminal.Description,
                            MercedesTerminalId = i.Brand.Terminal.MercedesTerminalId
                        },
                        MercedesTerminalId = i.Brand.MercedesTerminalId,
                        MercedesMarcaId = i.Brand.MercedesMarcaId
                    },
                    MercedesTerminalId = i.MercedesTerminalId,
                    MercedesMarcaId = i.MercedesMarcaId,
                    MercedesModeloId = i.MercedesModeloId
                }).FirstOrDefault();
                return new BaseResponse<CarModelDto>(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CarModelDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<CarModel> Create(CarModelDto dto)
        {
            try
            {
                var entity = Context.CarModels.SingleOrDefault(p => p.MercedesModeloId!.Equals(dto.MercedesModeloId) && p.MercedesMarcaId!.Equals(dto.MercedesMarcaId) && p.MercedesTerminalId!.Equals(dto.MercedesTerminalId));
                if (entity != null)
                    return new BaseResponse<CarModel>(StatusCodes.Status400BadRequest, $"ID de modelo existente: '{entity.Description}'.");
                entity = _mapper.Map<CarModel>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<CarModel>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<CarModel>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<CarModel> Update(CarModelDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<CarModel>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.CarModels.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<CarModel>(StatusCodes.Status400BadRequest, $"Id del modelo no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<CarModel>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<CarModel>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public dynamic addJson(dynamic json)
        {
            try
            {
                foreach (var js in json)
                {
                    var fact = new CarModel();
                    fact.Name = js.TXTSH;
                    fact.Description = js.TXTSH;
                    fact.MercedesMarcaId = js.idmarca;
                    fact.MercedesTerminalId = null;
                    fact.MercedesModeloId = js.idmodelo;
                    Context.CarModels.Add(fact);
                }
                Context.SaveChanges();
                return null;
            }
            catch (Exception ex)
            {
                return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
