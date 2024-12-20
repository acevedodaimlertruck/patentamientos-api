using System.Data;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos
{
    public class SaltoObjetoRepository : BaseRecolectorRepository<SaltoObjetoEntity>, ISaltoObjetoRepository
    {
        public SaltoObjetoRepository(RecolectorDbContext context) : base(context)
        {
        }

        public BaseResponse<SaltoObjetoDto> GetByCodVersion(string codVersion)
        {
            try
            {
                var query = (from so in Context.SaltoObjetos
                             join soi in Context.SaltoObjetoInvolucrados on so.CodSaltoObjeto equals soi.CodSaltoObjeto
                             join som in Context.SaltoObjetoMostrar on so.CodSaltoObjeto equals som.CodSaltoObjeto
                             join sm in Context.SeccionModulos on new { CodSeccionModulo = som.CodSeccionModulo, Activo = (bool?)true } equals new { CodSeccionModulo = sm.CodSeccionModulo, Activo = sm.Activo } into tmpSeccionesModulo
                             from sm2 in tmpSeccionesModulo.DefaultIfEmpty()
                             where so.Activo == true && soi.Activo == true && som.Activo == true && so.CodVersion.Equals(codVersion) && !som.CodTipoSalto.Equals("COD_TIPO_VALIDACION_SIMPLE")
                             group new
                             {
                                 so.CodSaltoObjeto,
                                 so,
                                 soi,
                                 som,
                                 sm2
                             } by new
                             {
                                 so.CodSaltoObjeto
                             } into g
                             select g
                        //select new SaltoObjetoDto
                        //{
                        //    CodSaltoObjeto = g.Key.CodSaltoObjeto,
                        //    CodTipoSalto = g.Select(gi => gi.som.CodTipoSalto).FirstOrDefault(),
                        //    Condicion = g.Select(gi => gi.so.Condicion).FirstOrDefault(),
                        //    CodSeccionModulo = g.Select(gi => gi.som.CodSeccionModulo).FirstOrDefault(),
                        //    Obligatoria = g.Select(gi => gi.som.Obligatoria).FirstOrDefault(),
                        //    CodObjetosInvolucrados = string.Join(",", g.Select(gi => gi.soi.CodObjetoInvolucrado)),
                        //    CodObjetosMostrar = string.Join(",", g.Select(gi => gi.som.CodObjeto)),
                        //    CodOpcionesMostrar = string.Join(",", g.Select(gi => gi.som.CodOpcionAMostrar))
                        //}
                        );
                var group = query.ToList();
                var saltosObjeto = group.Select(g => new SaltoObjetoDto
                {
                    CodSaltoObjeto = g.Key.CodSaltoObjeto,
                    CodTipoSalto = g.Select(gi => gi.som.CodTipoSalto).FirstOrDefault(),
                    Condicion = g.Select(gi => gi.so.Condicion).FirstOrDefault(),
                    CodModulo = g.Select(gi => gi.sm2 != null ? gi.sm2.CodModulo : "").FirstOrDefault(),
                    CodSeccionModulo = g.Select(gi => gi.som.CodSeccionModulo).FirstOrDefault(),
                    Obligatoria = g.Select(gi => gi.som.Obligatoria).FirstOrDefault(),
                    CodObjetosInvolucrados = string.Join(",", g.Select(gi => gi.soi.CodObjetoInvolucrado).Distinct()),
                    CodObjetosMostrar = string.Join(",", g.Select(gi => gi.som.CodObjeto).Distinct()),
                    CodOpcionesMostrar = string.Join(",", g.Select(gi => gi.som.CodOpcionMostrar).Distinct())
                }).Distinct().ToList();
                //foreach (var saltoObjeto in saltosObjeto)
                //{
                //    saltoObjeto.CodObjetosInvolucrados = (from soi in Context.SaltosObjetoInvolucrado
                //                                          where soi.Activo == true && soi.CodSaltoObjeto.Equals(saltoObjeto.CodSaltoObjeto)
                //                                          select soi.CodObjetoInvolucrado).ToList();
                //    saltoObjeto.CodObjetosMostrar = (from som in Context.SaltosObjetoMostrar
                //                                     where som.Activo == true && som.CodSaltoObjeto.Equals(saltoObjeto.CodSaltoObjeto)
                //                                     select som.CodObjeto).ToList();
                //    saltoObjeto.CodOpcionesMostrar = (from som in Context.SaltosObjetoMostrar
                //        where som.Activo == true && som.CodSaltoObjeto.Equals(saltoObjeto.CodSaltoObjeto)
                //        select som.CodOpcionAMostrar).ToList();
                //}
                return new BaseResponse<SaltoObjetoDto>(StatusCodes.Status200OK, saltosObjeto);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SaltoObjetoDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<ValidacionSimpleDto> GetValidacionesSimplesByCodVersion(string codVersion)
        {
            try
            {
                var query = (from so in Context.SaltoObjetos
                             join soi in Context.SaltoObjetoInvolucrados on so.CodSaltoObjeto equals soi.CodSaltoObjeto
                             join som in Context.SaltoObjetoMostrar on so.CodSaltoObjeto equals som.CodSaltoObjeto
                             where so.Activo == true && soi.Activo == true && som.Activo == true && so.CodVersion.Equals(codVersion) && som.CodTipoSalto.Equals("COD_TIPO_VALIDACION_SIMPLE")
                             group new
                             {
                                 so.CodSaltoObjeto,
                                 so,
                                 soi,
                                 som,
                             } by new
                             {
                                 so.CodSaltoObjeto
                             } into g
                             select g
                        );
                var group = query.ToList();
                var validacionesSimples = group.Select(g => new ValidacionSimpleDto
                {
                    CodValidacionSimple = g.Key.CodSaltoObjeto,
                    Requerido = false,
                    MinLength = 0,
                    MaxLength = 0,
                    Condicion = g.Select(gi => gi.so.Condicion).FirstOrDefault(),
                    MjeError = g.Select(gi => gi.so.Comentario).FirstOrDefault(),
                    CodPreguntasEnCondicion = string.Join(",", g.Select(gi => gi.soi.CodObjetoInvolucrado).Distinct()),
                    CodPreguntasMostrarMjeError = string.Join(",", g.Select(gi => gi.som.CodObjeto).Distinct()),
                }).Distinct().ToList();
                return new BaseResponse<ValidacionSimpleDto>(StatusCodes.Status200OK, validacionesSimples);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ValidacionSimpleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}