using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OFMM
{
    public class OfmmRepository : BaseRepository<Ofmm>, IOfmmRepository
    {
        private readonly IMapper _mapper;

        public OfmmRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<OfmmDto> GetAll2()
        {
            try
            {
                var results = Context.Ofmms.Select(i => new OfmmDto
                {
                    Id = i.Id,
                    ZOFMM = i.ZOFMM,
                    ValidoHasta = i.ValidoHasta,
                    ValidoDesde = i.ValidoDesde,
                    FabricaPat = i.FabricaPat,
                    MarcaPat = i.MarcaPat,
                    MODELOPAT = i.MODELOPAT,
                    Descripcion1 = i.Descripcion1,
                    Descripcion2 = i.Descripcion2,
                    TipoDeTexto = i.TipoDeTexto,
                    Terminal = i.Terminal,
                    Marca = i.Marca,
                    Modelo = i.Modelo,
                    VersionPatentamiento = i.VersionPatentamiento,
                    Origen = i.Origen,
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            Description = i.CarModel.Brand.Description,
                            MercedesTerminalId = i.CarModel.Brand.MercedesTerminalId,
                            MercedesMarcaId = i.CarModel.Brand.MercedesMarcaId,
                            TerminalId = i.CarModel.Brand.TerminalId,
                            Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                            {
                                Id = i.CarModel.Brand.Terminal.Id,
                                Name = i.CarModel.Brand.Terminal.Name,
                                Description = i.CarModel.Brand.Terminal.Description,
                                MercedesTerminalId = i.CarModel.Brand.Terminal.MercedesTerminalId
                            }
                        },
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId
                    },
                    FactoryId = i.FactoryId,
                    Factory = i.Factory == null ? null : new FactoryDto
                    {
                        Id = i.Factory.Id,
                        Name = i.Factory.Name,
                        Description = i.Factory.Description,
                        MercedesFabricaId = i.Factory.MercedesFabricaId
                    }
                }).OrderBy(i => i.ZOFMM).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<OfmmDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<OfmmDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Ofmm> Create(OfmmDto dto)
        {
            try
            {
                var entity = Context.Ofmms.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<Ofmm>(StatusCodes.Status400BadRequest, $"El OFMM ya existe.");
                entity = _mapper.Map<Ofmm>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<Ofmm>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Ofmm>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<IEnumerable<Ofmm>> CreateMultipleOfmms(IEnumerable<OfmmDto> dtos)
        {
            try
            {
                List<Ofmm> entities = new List<Ofmm>();

                foreach (var dto in dtos)
                {
                    var existingEntity = Context.Ofmms.SingleOrDefault(p => p.Id.Equals(dto.Id));
                    if (existingEntity != null)
                    {
                        _mapper.Map(dto, existingEntity);
                        UpdateAndSave(existingEntity);
                    } else { 
                        var entity = _mapper.Map<Ofmm>(dto);
                        if (entity.Id == Guid.Empty) 
                            entity.Id = Guid.NewGuid();
                        entities.Add(entity);
                    }
                }
                if (entities.Any())
                    BulkInsert(entities);
                return new BaseResponse<IEnumerable<Ofmm>>(StatusCodes.Status200OK, entities);
            }
            catch (Exception e)
            {
                return new BaseResponse<IEnumerable<Ofmm>>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }


        public BaseResponse<Ofmm> Update(OfmmDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<Ofmm>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.Ofmms.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<Ofmm>(StatusCodes.Status400BadRequest, $"Id de OFMM no encontrado.");
                entity.ValidoHasta = DateTime.Now;
                UpdateAndSave(entity);
                var newEntity = _mapper.Map<Ofmm>(dto);
                newEntity.Id = Guid.NewGuid();
                InsertAndSave(newEntity);
                return new BaseResponse<Ofmm>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<Ofmm>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                    DateTime dateTime;
                    DateTime dateTime1;
                    var fact = new Ofmm();

                    string dateString1 = js.VALIDOHASTA; // Replace with your date string
                    if (DateTime.TryParse(dateString1, out dateTime1))
                    {
                        Console.WriteLine(dateTime1);
                        fact.ValidoHasta = dateTime1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format");
                        fact.ValidoHasta = null;
                    }
                    string dateString = js.VALIDODESDE; // Replace with your date string
                    if (DateTime.TryParse(dateString, out dateTime))
                    {
                        Console.WriteLine(dateTime);
                        fact.ValidoDesde = dateTime;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format");
                        fact.ValidoDesde = null;
                    }
                    // check modelo
                    if (js.MODELO != null)
                    {
                        string modeloid = js.MODELO;
                        var modelo = Context.CarModels.Where(r => r.MercedesModeloId == modeloid).FirstOrDefault();
                        if (modelo != null)
                        {
                            fact.CarModelId = modelo.Id;
                        }
                        else
                        {
                            fact.CarModelId = Guid.Parse("395B01DA-B7E3-4893-AB6C-807C2629BC1A");
                        }
                    }
                    else
                    {
                        fact.CarModelId = Guid.Parse("395B01DA-B7E3-4893-AB6C-807C2629BC1A");
                    }
                    //check fabrica
                    if (js.FABRICAPAT != null)
                    {
                        string factoryid = js.FABRICAPAT;
                        var factory = Context.Factories.Where(r => r.MercedesFabricaId == factoryid).FirstOrDefault();
                        if (factory != null)
                        {
                            fact.FactoryId = factory.Id;
                        }
                        else
                        {
                            fact.FactoryId = Guid.Parse("0208A9E5-56B5-41D8-96EE-27E4E8F41AD4");
                        }
                    }
                    else
                    {
                        fact.FactoryId = Guid.Parse("0208A9E5-56B5-41D8-96EE-27E4E8F41AD4");
                    }

                    //check brand
                    //if (js.MARCAPAT != null)
                    //{
                    //    string marcaid = js.MARCAPAT;
                    //    var brand = Context.Brands.Where(r => r.MercedesMarcaId == marcaid).FirstOrDefault();
                    //    if (brand != null)
                    //    {
                    //        fact.BrandId = brand.Id;
                    //    }
                    //    else
                    //    {
                    //        fact.BrandId = Guid.Parse("DE6A5D56-31C3-4A4D-98D8-9E1E7794F004");
                    //    }
                    //}
                    //else
                    //{
                    //    fact.BrandId = Guid.Parse("DE6A5D56-31C3-4A4D-98D8-9E1E7794F004");
                    //}
                    fact.ZOFMM = js.ZOFMM;
                    fact.Descripcion1 = js.DESCRIPCION1;
                    fact.Descripcion2 = js.DESCRIPCION2;
                    fact.TipoDeTexto = js.TIPODETEXTO;
                    fact.VersionPatentamiento = js.VERSIONPATENTAMIENTO;
                    fact.Modelo = js.MODELO;
                    fact.Marca = js.MARCA;
                    fact.Terminal = js.TERMINAL;
                    fact.FabricaPat = js.FABRICAPAT;
                    fact.MarcaPat = js.MARCAPAT;
                    fact.MODELOPAT = js.MODELOPAT;

                    Context.Ofmms.Add(fact);
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
