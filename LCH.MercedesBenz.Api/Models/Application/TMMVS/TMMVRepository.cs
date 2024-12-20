using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.TMMVS.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.TMMVS
{
    public class TMMVRepository : BaseRepository<TMMV>, ITMMVRepository
    {
        private readonly IMapper _mapper;

        public TMMVRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

           public BaseResponse<TMMVDto> GetAll2()
        {
            try
            {
                var results = Context.TMMVs.Select(i => new TMMVDto
                {
                    Id = i.Id,
                    VersionPatentamiento = i.VersionPatentamiento,
                    VersionWs = i.VersionWs,
                    VersionInterna = i.VersionInterna,
                    DescripcionTerminal = i.DescripcionTerminal,
                    DescripcionMarca = i.DescripcionMarca,
                    DescripcionModelo = i.DescripcionModelo,
                    DescripcionVerPat = i.DescripcionVerPat,
                    DescripcionVerWs = i.DescripcionVerWs,
                    DescripcionVerInt = i.DescripcionVerInt,
                    //BrandId = i.BrandId,
                    MercedesMarcaId = i.MercedesMarcaId,
                    CarModelId = i.CarModelId,
                    MercedesModeloId = i.MercedesModeloId,
                    //TerminalId = i.TerminalId,
                    MercedesTerminalId = i.MercedesTerminalId
                }).OrderBy(i => i.Id).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<TMMVDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<TMMVDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<TMMV> Create(TMMVDto dto)
        {
            try
            {
                var entity = Context.TMMVs.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<TMMV>(StatusCodes.Status400BadRequest, $"La TMMV ya existe.");
                var duplicated = Context.TMMVs.SingleOrDefault(p => p.VersionPatentamiento.Equals(dto.VersionPatentamiento) && p.VersionWs.Equals(dto.VersionWs) && p.VersionInterna.Equals(dto.VersionInterna) && p.MercedesTerminalId.Equals(dto.MercedesTerminalId) && p.MercedesMarcaId.Equals(dto.MercedesMarcaId) && p.MercedesModeloId.Equals(dto.MercedesModeloId));
                if (duplicated != null)
                    return new BaseResponse<TMMV>(StatusCodes.Status400BadRequest, $"La combinación TMMVi + vPat +vWs ya existe");
                entity = _mapper.Map<TMMV>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<TMMV>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<TMMV>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<TMMV> Update(TMMVDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<TMMV>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.TMMVs.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<TMMV>(StatusCodes.Status400BadRequest, $"Id de TMMV no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<TMMV>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<TMMV>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
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
                    var fact = new TMMV();
                    // check modelo
                    if (js.modeloid != null)
                    {
                        string modeloid = js.modeloid;
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
                    //// check brand
                    //if (js.marcaid != null)
                    //{
                    //    string marcaid = js.marcaid;
                    //    var marca = Context.Brands.Where(r => r.MercedesMarcaId == marcaid).FirstOrDefault();
                    //    if (marca != null)
                    //    {
                    //        fact.BrandId = marca.Id;
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
                    // check terminal
                    //if (js.termid != null)
                    //{
                    //    string termid = js.termid;
                    //    var termin = Context.Terminals.Where(r => r.MercedesTerminalId == termid).FirstOrDefault();
                    //    if (termin != null)
                    //    {
                    //        fact.TerminalId = termin.Id;
                    //    }
                    //    else
                    //    {
                    //        fact.TerminalId = Guid.Parse("86166d2d-9fc4-470d-8d5f-bdf176d32b6a");
                    //    }
                    //}
                    //else
                    //{
                    //    fact.TerminalId = Guid.Parse("86166d2d-9fc4-470d-8d5f-bdf176d32b6a");
                    //}
                    fact.VersionPatentamiento = js.verpat;
                    fact.VersionWs = js.verws;
                    fact.VersionInterna = js.verint;
                    fact.DescripcionTerminal = js.DESC_TERM;
                    fact.DescripcionMarca = js.DESC_MARC;
                    fact.DescripcionModelo = js.DESC_MODL;
                    fact.DescripcionVerPat = js.DESC_VERP;
                    fact.DescripcionVerWs = js.DESC_VERW;
                    fact.DescripcionVerInt = js.DESC_VERI;
                    Context.TMMVs.Add(fact);
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

        public BaseResponse<TMMVDto> GetVerPats(Guid carModelId)
        {
            try
            {
                var carModel = Context.CarModels.SingleOrDefault(cm => cm.Id.Equals(carModelId));
                if (carModel == null)
                {
                    return new BaseResponse<TMMVDto>(StatusCodes.Status400BadRequest, $"No se encontrö un modelo con el Id proporcionado, intente con otro.");
                }
                var results = Context.TMMVs.Where(cm => cm.MercedesTerminalId!.Equals(carModel.MercedesTerminalId) && cm.MercedesMarcaId!.Equals(carModel.MercedesMarcaId) && cm.MercedesModeloId!.Equals(carModel.MercedesModeloId))
                    .Where(i => !string.IsNullOrEmpty(i.VersionPatentamiento))
                    .Select(i => new TMMVDto
                {
                    Id = i.Id,
                    VersionPatentamiento = i.VersionPatentamiento,
                    DescripcionVerPat = i.DescripcionVerPat,
                    CarModelId = i.CarModelId,
                    MercedesMarcaId = i.MercedesMarcaId,
                    MercedesModeloId = i.MercedesModeloId,
                    MercedesTerminalId = i.MercedesTerminalId
                }).ToList();
                results = results.OrderBy(i => int.TryParse(i.VersionPatentamiento, out int versionNumber) ? versionNumber : int.MaxValue).Distinct().ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<TMMVDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<TMMVDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
