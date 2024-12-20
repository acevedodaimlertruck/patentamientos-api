using System.Data;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Entidades;
using LCH.MercedesBenz.Api.Models.Recolector.Respuestas.Dtos;
using StoredProcedureEFCore;

namespace LCH.MercedesBenz.Api.Models.Recolector.Respuestas
{
    public class RespuestaRepository : BaseRecolectorRepository<RespuestaEntity>, IRespuestaRepository
    {
        private readonly IEntidadRepository _entidadRepository;

        public RespuestaRepository(
            RecolectorDbContext context,
            IEntidadRepository entidadRepository) : base(context)
        {
            _entidadRepository = entidadRepository;
        }

        public BaseResponse<RespuestaDto> GetRespuestas(string codVersion, string codVisita)
        {
            try
            {
                var respuestas = (from r in Context.Respuestas
                                  join ps in Context.PreguntaSecciones on new
                                  {
                                      CodPreguntaSeccion = r.CodPreguntaSeccion,
                                      Activo = (int?)1
                                  } equals new
                                  {
                                      CodPreguntaSeccion = ps.CodPreguntaSeccion,
                                      Activo = ps.Activo
                                  }
                                  join sm in Context.SeccionModulos on ps.CodSeccionModulo equals sm.CodSeccionModulo
                                  join m in Context.Modulos on new
                                  {
                                      CodModulo = sm.CodModulo,
                                      CodVersion = codVersion,
                                      Activo = (bool?)true
                                  } equals new
                                  {
                                      CodModulo = m.CodModulo,
                                      CodVersion = m.CodVersion,
                                      Activo = m.Activo
                                  }
                                  where r.Activo == true && r.CodVersion.Equals(codVersion) && r.CodVisita.Equals(codVisita)
                                  select new RespuestaDto
                                  {
                                      IdRespuesta = r.IdRespuesta,
                                      TipoDatoCodigo = r.TipoDatoCodigo,
                                      CodVisita = r.CodVisita,
                                      CodPreguntaSeccion = r.CodPreguntaSeccion,
                                      CodDetallePregunta = r.CodDetallePregunta,
                                      CodOpcion = r.CodOpcion,
                                      CodEntidad = r.CodEntidad,
                                      RespuestaAlfanumerico = r.RespuestaAlfanumerico,
                                      Agrupamiento = r.Agrupamiento,
                                      CodBloque = ps.CodBloque,
                                  }
                            ).OrderBy(r => r.CodBloque).ThenBy(r => r.Agrupamiento).Distinct().ToList();
                return new BaseResponse<RespuestaDto>(StatusCodes.Status200OK, respuestas);
            }
            catch (Exception ex)
            {
                return new BaseResponse<RespuestaDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>> GetRespuestasPorSeccionEntidad(string codVersion, string codVisita)
        {
            try
            {
                var secciones = (from f in Context.Formularios
                                 join v in Context.Versiones on f.CodFormulario equals v.CodFormulario
                                 join m in Context.Modulos on v.CodVersion equals m.CodVersion
                                 join sm in Context.SeccionModulos on m.CodModulo equals sm.CodModulo
                                 where f.Activo == true && v.Activo == true && m.Activo == true && sm.Activo == true && v.CodVersion.Equals(codVersion)
                                 select new
                                 {
                                     CodSeccionModulo = sm.CodSeccionModulo,
                                     CodModulo = sm.CodModulo,
                                     Modulo = m.Modulo,
                                     CodSeccion = sm.CodSeccion,
                                     Seccion = sm.TextoAlternativo,
                                     CodObjeto = sm.CodObjeto,
                                     OrdenModulo = m.Orden,
                                     OrdenSeccion = sm.Orden,
                                 }
                    ).OrderBy(sm => sm.OrdenModulo).ThenBy(sm => sm.OrdenSeccion).Distinct().ToList<dynamic>();

                if (secciones.Count == 0)
                {
                    var response = new BaseResponse<Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>>();
                    response.StatusCode = StatusCodes.Status200OK;
                    response.Result = null;
                    return response;
                }

                var entidadesResponse = _entidadRepository.GetEntidades(codVersion, codVisita);
                if (entidadesResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>>(entidadesResponse.StatusCode, entidadesResponse.Message, entidadesResponse.StackTrace);
                var entidades = entidadesResponse.Results;

                if (entidades == null || entidades.Count == 0)
                {
                    var response = new BaseResponse<Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>>();
                    response.StatusCode = StatusCodes.Status200OK;
                    response.Result = null;
                    return response;
                }

                var respuestasPorSeccionEntidad = new Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>();

                foreach (var seccion in secciones)
                {
                    var codModulo = (string)seccion.CodModulo;
                    var modulo = (string)seccion.Modulo;
                    var codSeccion = (string)seccion.CodSeccion;
                    var seccionTextoAlternativo = (string)seccion.Seccion;
                    var codSeccionModulo = (string)seccion.CodSeccionModulo;
                    var respuestasPorEntidad = new Dictionary<string, ICollection<RespuestaDto>>();
                    foreach (var entidad in entidades)
                    {
                        var respuestas = (from r in Context.Respuestas
                                          join ps in Context.PreguntaSecciones on new
                                          {
                                              CodPreguntaSeccion = r.CodPreguntaSeccion,
                                              Activo = (int?)1
                                          } equals new
                                          {
                                              CodPreguntaSeccion = ps.CodPreguntaSeccion,
                                              Activo = ps.Activo
                                          }
                                          join sm in Context.SeccionModulos on ps.CodSeccionModulo equals sm.CodSeccionModulo
                                          join m in Context.Modulos on new
                                          {
                                              CodModulo = sm.CodModulo,
                                              CodVersion = codVersion,
                                              Activo = (bool?)true
                                          } equals new
                                          {
                                              CodModulo = m.CodModulo,
                                              CodVersion = m.CodVersion,
                                              Activo = m.Activo
                                          }
                                          where r.Activo == true && r.CodVersion.Equals(codVersion) && r.CodVisita.Equals(codVisita) && sm.CodSeccionModulo.Equals(codSeccionModulo) && r.CodEntidad.Equals(entidad.CodEntidad)
                                          select new RespuestaDto
                                          {
                                              IdRespuesta = r.IdRespuesta,
                                              TipoDatoCodigo = r.TipoDatoCodigo,
                                              CodVisita = r.CodVisita,
                                              CodPreguntaSeccion = r.CodPreguntaSeccion,
                                              CodDetallePregunta = r.CodDetallePregunta,
                                              CodOpcion = r.CodOpcion,
                                              CodEntidad = r.CodEntidad,
                                              RespuestaAlfanumerico = r.RespuestaAlfanumerico,
                                              Agrupamiento = r.Agrupamiento,
                                              CodBloque = ps.CodBloque,
                                          }
                            ).OrderBy(r => r.CodBloque).ThenBy(r => r.Agrupamiento).Distinct().ToList();
                        respuestasPorEntidad.Add(entidad.CodEntidad, respuestas);
                    }
                    respuestasPorSeccionEntidad.Add(seccion.CodSeccionModulo, respuestasPorEntidad);
                }

                return new BaseResponse<Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>>(StatusCodes.Status200OK, respuestasPorSeccionEntidad);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> Guardar(
            string respuestas,
            string codVersion,
            string codVisita,
            string codUsuario,
            string codTipoDato,
            string accion,
            string valorViejo,
            string codOpcionViejo,
            string codBloque)
        {
            try
            {
                List<dynamic> results = new List<dynamic>();
                Context.LoadStoredProc("[dbo].[usp_AltaMod_Respuestas2]")
                    .AddParam("Respuestas", respuestas)
                    .AddParam("CodVersion", codVersion)
                    .AddParam("CodVisita", codVisita)
                    .AddParam("CodUsuario", codUsuario)
                    .AddParam("CodTipoDato", codTipoDato)
                    .AddParam("Accion", accion)
                    .AddParam("ValorViejo", valorViejo)
                    .AddParam("CodOpcionViejo", codOpcionViejo)
                    .AddParam("CodBloque", codBloque)
                    .Exec(action => results = action.ToList<dynamic>());
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
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

        public BaseResponse<dynamic> BorrarBySeccion(
            string codSeccionModulo,
            string codVersion,
            string codVisita,
            string codUsuario,
            string codEntidad)
        {
            try
            {
                List<dynamic> results = new List<dynamic>();
                Context.LoadStoredProc("[dbo].[usp_DeleteRespuestasBySeccModulo]")
                    .AddParam("CodSeccionModulo", codSeccionModulo)
                    .AddParam("CodVersion", codVersion)
                    .AddParam("CodVisita", codVisita)
                    .AddParam("CodUsuario", codUsuario)
                    .AddParam("CodEntidad", codEntidad)
                    .Exec(action => results = action.ToList<dynamic>());
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
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

        public BaseResponse<dynamic> BorrarByAgrupamiento(
            string codVersion,
            string codVisita,
            string agrupamiento,
            string codBloque)
        {
            try
            {
                List<dynamic> results = new List<dynamic>();
                Context.LoadStoredProc("[dbo].[usp_DeleteRespuestaByAgrupamiento]")
                    .AddParam("CodVersion", codVersion)
                    .AddParam("CodVisita", codVisita)
                    .AddParam("agrupamiento", agrupamiento)
                    .AddParam("codBloque", codBloque)
                    .Exec(action => results = action.ToList<dynamic>());
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
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

        public BaseResponse<dynamic> BorrarByAgrupamientos(
            string codSeccionModulo,
            string codVisita,
            string agrupamiento)
        {
            try
            {
                List<dynamic> results = new List<dynamic>();
                Context.LoadStoredProc("[dbo].[usp_DeleteRespuestaByAgrupamientos]")
                    .AddParam("CodSeccionModulo", codSeccionModulo)
                    .AddParam("CodVisita", codVisita)
                    .AddParam("agrupamiento", agrupamiento)
                    .Exec(action => results = action.ToList<dynamic>());
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
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

        public BaseResponse<dynamic> BorrarMasivo(
            string codVersion,
            string codVisita,
            string codPreguntaSeccion,
            string codEntidad,
            string codOpcionOmitir,
            string agrupamiento)
        {
            try
            {
                List<dynamic> results = new List<dynamic>();
                Context.LoadStoredProc("[dbo].[usp_DeleteRespuestaMasiva]")
                    .AddParam("CodVersion", codVersion)
                    .AddParam("CodVisita", codVisita)
                    .AddParam("CodPreguntaSeccion", codPreguntaSeccion)
                    .AddParam("CodEntidad", codEntidad)
                    .AddParam("CodOpcion", codOpcionOmitir)
                    .AddParam("Agrupamiento", agrupamiento)
                    .Exec(action => results = action.ToList<dynamic>());
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
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
