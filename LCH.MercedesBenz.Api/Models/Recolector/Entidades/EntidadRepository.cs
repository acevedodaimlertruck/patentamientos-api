using System.Data;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Entidades.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Entidades
{
    public class EntidadRepository : IEntidadRepository
    {
        private readonly RecolectorDbContext Context;

        public EntidadRepository(
            RecolectorDbContext context)
        {
            Context = context;
        }

        public BaseResponse<EntidadDto> GetEntidades(string codVersion, string codVisita, bool incluirPersonas = true, bool incluirViviendas = true, bool dispose = true)
        {
            try
            {
                var entidades = new List<EntidadDto>();

                if (incluirPersonas)
                {
                    var personas = (from p in Context.Personas
                                    join pf in Context.PersonaFamilias on p.CodPersona equals pf.CodPersona
                                    join fv in Context.FamiliaVisitas on pf.CodFamiliaVisita equals fv.CodFamiliaVisita
                                    join v in Context.Visitas on fv.CodVisita equals v.CodVisita
                                    join r in Context.Respuestas on new
                                    {
                                        Activo = (bool?)true,
                                        CodVersion = codVersion,
                                        CodVisita = codVisita,
                                        CodObjeto = "COD_PERSONA",
                                        CodEntidad = p.CodPersona,
                                        CodPreguntaSeccion = "COD_PREG_SEC_428_RELEVAMIENTO",
                                    } equals new
                                    {
                                        Activo = r.Activo,
                                        CodVersion = r.CodVersion,
                                        CodVisita = r.CodVisita,
                                        CodObjeto = r.CodObjeto,
                                        CodEntidad = r.CodEntidad,
                                        CodPreguntaSeccion = r.CodPreguntaSeccion,
                                    } into tempRespuestas
                                    from r2 in tempRespuestas.DefaultIfEmpty()
                                    where pf.Activo == true && fv.Activo == true && v.Activo == true && fv.CodVisita.Equals(codVisita)
                                    select new EntidadDto
                                    {
                                        //CodModulo = codModulo,
                                        //Modulo = modulo,
                                        //CodSeccion = codSeccion,
                                        //Seccion = seccionTextoAlternativo,
                                        CodEntidad = p.CodPersona,
                                        CodObjeto = "COD_PERSONA",
                                        NombreCompleto = p.Apellidos + ", " + p.Nombres,
                                        FechaNacimiento = p.FechaNacimiento,
                                        CodSexo = p.CodSexo,
                                        CodTipoEstadoCivil = p.CodTipoEstadoCivil,
                                        FechaRegistroRespuesta = r2 != null ? r2.FechaRegistro : null,
                                        FechaInicialVisita = v.FechaInicial,
                                        CodHogar = pf.CodHogar,
                                        Hogar = pf.Hogar,
                                        JefeDeHogar = pf.JefeDeHogar,
                                    }).ToList();
                    entidades.AddRange(personas);
                }

                if (incluirViviendas)
                {
                    var viviendas = (from v in Context.Viviendas
                                     where v.CodVisita.Equals(codVisita)
                                     select new EntidadDto
                                     {
                                         //CodModulo = codModulo,
                                         //Modulo = modulo,
                                         //CodSeccion = codSeccion,
                                         //Seccion = seccionTextoAlternativo,
                                         CodEntidad = v.CodVivienda,
                                         CodObjeto = "COD_VIVIENDA",
                                         NombreCompleto = "VIVIENDA",
                                         FechaNacimiento = (DateTime?)null,
                                         CodSexo = "",
                                         CodTipoEstadoCivil = "",
                                         FechaRegistroRespuesta = (DateTime?)null,
                                         FechaInicialVisita = (DateTime?)null,
                                         CodHogar = "",
                                         Hogar = "",
                                         JefeDeHogar = (bool?)null,
                                     }).ToList();


                    entidades.AddRange(viviendas);
                }

                return new BaseResponse<EntidadDto>(StatusCodes.Status200OK, entidades);
            }
            catch (Exception ex)
            {
                return new BaseResponse<EntidadDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                if (dispose)
                    Context.Dispose();
            }
        }

        public BaseResponse<Dictionary<string, ICollection<EntidadDto>>> GetEntidadesPorSeccion(string codVersion, string codVisita)
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

                if (secciones.Count == 0) return null;

                var entidadesPorSeccion = new Dictionary<string, ICollection<EntidadDto>>();

                var entidadesResponse = GetEntidades(codVersion, codVisita, true, true, false);
                if (entidadesResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<Dictionary<string, ICollection<EntidadDto>>>(entidadesResponse.StatusCode, entidadesResponse.Message, entidadesResponse.StackTrace);
                var entidades = entidadesResponse.Results;

                //var personasResponse = GetEntidades(codVersion, codVisita, true, false, false);
                //if (personasResponse.StatusCode != StatusCodes.Status200OK)
                //    return new BaseResponse<Dictionary<string, ICollection<EntidadDto>>>(personasResponse.StatusCode, personasResponse.Message, personasResponse.StackTrace);
                //var personas = personasResponse.Results;

                //var viviendasResponse = GetEntidades(codVersion, codVisita, false, true, false);
                //if (viviendasResponse.StatusCode != StatusCodes.Status200OK)
                //    return new BaseResponse<Dictionary<string, ICollection<EntidadDto>>>(viviendasResponse.StatusCode, viviendasResponse.Message, viviendasResponse.StackTrace);
                //var viviendas = viviendasResponse.Results;

                foreach (var seccion in secciones)
                {
                    var codModulo = (string)seccion.CodModulo;
                    var modulo = (string)seccion.Modulo;
                    var codSeccion = (string)seccion.CodSeccion;
                    var seccionTextoAlternativo = (string)seccion.Seccion;
                    if (seccion.CodObjeto.Equals("COD_PERSONA"))
                    {
                        var personas = entidades.Where(e => e.CodObjeto.Equals("COD_PERSONA")).ToList();
                        entidadesPorSeccion.Add(seccion.CodSeccionModulo, personas);
                    }
                    else if (seccion.CodObjeto.Equals("COD_VIVIENDA"))
                    {
                        var viviendas = entidades.Where(e => e.CodObjeto.Equals("COD_VIVIENDA")).ToList();
                        entidadesPorSeccion.Add(seccion.CodSeccionModulo, viviendas);
                    }
                    else
                    {

                    }
                }

                return new BaseResponse<Dictionary<string, ICollection<EntidadDto>>>(StatusCodes.Status200OK, entidadesPorSeccion);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Dictionary<string, ICollection<EntidadDto>>>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Context.Dispose();
            }
        }
    }
}