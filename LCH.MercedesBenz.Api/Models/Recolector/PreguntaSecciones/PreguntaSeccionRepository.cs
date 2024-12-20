using System.Data;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Opciones.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.Personas;
using LCH.MercedesBenz.Api.Models.Recolector.PreguntasSeccion.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.PreguntaSecciones
{
    public class PreguntaSeccionRepository : BaseRecolectorRepository<PreguntaSeccionEntity>, IPreguntaSeccionRepository
    {
        private readonly IPersonaRepository _personaRepository;

        public PreguntaSeccionRepository(
            RecolectorDbContext context,
            IPersonaRepository personaRepository) : base(context)
        {
            _personaRepository = personaRepository;
        }

        public BaseResponse<Dictionary<string, ICollection<PreguntaSeccionDto>>> GetPreguntasPorSeccion(string codVersion, string codVisita)
        {
            try
            {
                var preguntasPorSeccion = new Dictionary<string, ICollection<PreguntaSeccionDto>>();

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

                var personasResponse = _personaRepository.GetPersonas(codVersion, codVisita);
                if (personasResponse.StatusCode != StatusCodes.Status200OK)
                    return new BaseResponse<Dictionary<string, ICollection<PreguntaSeccionDto>>>(personasResponse.StatusCode, personasResponse.Message, personasResponse.StackTrace);
                var personas = personasResponse.Results;

                var opcionesP = personas.Select(p => new OpcionDto
                {
                    CodOpcion = p.CodEntidad,
                    DestildaTodo = false,
                    TextoAlternativo = p.NombreCompleto,
                    CodObjeto = p.CodObjeto,
                    CodColor = null,
                    Orden = null,
                }).ToList();

                foreach (var seccion in secciones)
                {
                    var codModulo = (string)seccion.CodModulo;
                    var modulo = (string)seccion.Modulo;
                    var codSeccion = (string)seccion.CodSeccion;
                    var seccionTextoAlternativo = (string)seccion.Seccion;
                    var codSeccionModulo = (string)seccion.CodSeccionModulo;
                    var preguntas = (from ps in Context.PreguntaSecciones
                                     join co in Context.ColumnaObjetos on (from co3 in Context.ColumnaObjetos where co3.CodPregunta.Equals(ps.CodPregunta) && co3.Activo == true && !co3.CodObjeto.Equals("COD_FAMILIA") select co3.IdColumnaObjeto).FirstOrDefault() equals co.IdColumnaObjeto into tempColumnasObjeto
                                     from co2 in tempColumnasObjeto.DefaultIfEmpty()
                                     join b in Context.Bloques on new { CodBloque = ps.CodBloque, CodVersion = codVersion, Activo = (bool?)true } equals new { CodBloque = b.CodBloque, CodVersion = b.CodVersion, Activo = b.Activo } into tempBloques
                                     from b2 in tempBloques.DefaultIfEmpty()
                                     join bg in Context.BloqueGrillas on new { CodBloque = b2 != null ? b2.CodBloque : null, CodPreguntaSeccion = ps.CodPreguntaSeccion, Activo = (bool?)true } equals new { CodBloque = bg.CodBloque, CodPreguntaSeccion = bg.CodPreguntaSeccion, Activo = bg.Activo } into tempBloquesGrilla
                                     from bg2 in tempBloquesGrilla.DefaultIfEmpty()
                                     where ps.Activo == 1 && ps.CodSeccionModulo.Equals(codSeccionModulo)
                                     select new PreguntaSeccionDto
                                     {
                                         CodPreguntaSeccion = ps.CodPreguntaSeccion,
                                         CodSeccionModulo = ps.CodSeccionModulo,
                                         CodPregunta = ps.CodPregunta,
                                         Orden = ps.Orden,
                                         TextoAlternativo = ps.TextoAlternativo,
                                         CodTipoDato = ps.CodTipoDato,
                                         CodBloque = ps.CodBloque,
                                         TamanioHtml = ps.TamanioHtml,
                                         Orientacion = ps.Orientacion,
                                         Obligatoria = ps.Obligatoria,
                                         Visible = ps.Visible,
                                         Mascara = ps.Mascara,
                                         Javascript = ps.Javascript,
                                         Identificacion = ps.Identificacion,
                                         ValorDefecto = ps.ValorDefecto,
                                         Ayuda = ps.Ayuda,
                                         TipoCampo = ps.TipoCampo,
                                         CodPreguntaAux = ps.CodPreguntaAux,
                                         MostrarOrdenOpcion = ps.MostrarOrdenOpcion,
                                         CodObjeto = ps.CodObjeto,
                                         TablaDestino = ps.TablaDestino,
                                         CampoDestino = ps.CampoDestino,
                                         Metodo = ps.Metodo,
                                         Recargable = ps.Recargable,
                                         Duracion = ps.Duracion,
                                         Historial = ps.Historial,
                                         Lectura = ps.Lectura,
                                         ClaveBusqueda = ps.ClaveBusqueda,
                                         Restrictiva = ps.Restrictiva,
                                         ModificaEntidad = co2 != null && !"Cod_Contacto,COD_DATOS_DEL_BARRIO,COD_DATOS_DEL_BARRIO_2,COD_DATOS_DEL_CENSISTA,COD_DATOS_DEL_ENTREVISTADO,COD_DATOS_DEL_ENTREVISTADOR,COD_DATOS_GENERALES_BARRIO".Contains(codSeccion),
                                         Pivots = bg2 != null ? bg2.CodPreguntaSeccion : null,
                                         CodTipoBloque = bg2 != null && !string.IsNullOrEmpty(bg2.CodPreguntaSeccion) ? "GRILLA" : "SIMPLE",
                                     }).Distinct().OrderBy(ps => ps.Orden).ToList();
                    foreach (var pregunta in preguntas)
                    {
                        var opciones = (from op in Context.OpcionPreguntas
                                        join ps in Context.PreguntaSecciones on new
                                        {
                                            Activo = op.Activo,
                                            //CodSecMod = op.CodSeccionModulo,
                                            CodSeccionModulo = op.CodSeccionModulo,
                                            CodPreguntaSeccion = op.CodPreguntaSeccion
                                        } equals new
                                        {
                                            Activo = (int?)1,
                                            //CodSecMod = pregunta.CodSeccionModulo,
                                            CodSeccionModulo = ps.CodSeccionModulo,
                                            CodPreguntaSeccion = ps.CodPreguntaSeccion
                                        }
                                        join dg in Context.DatoGeometricos on new
                                        {
                                            Activo = (bool?)true,
                                            //CodSecMod = op.CodSeccionModulo,
                                            CodSeccionModulo = op.CodSeccionModulo,
                                            CodOpcionPregunta = op.CodOpcionPregunta
                                        } equals new
                                        {
                                            Activo = dg.Activo,
                                            //CodSecMod = pregunta.CodSeccionModulo,
                                            CodSeccionModulo = dg.CodSeccionModulo,
                                            CodOpcionPregunta = dg.CodOpcionPregunta
                                        } into tempDatosGeometrico
                                        from dg2 in tempDatosGeometrico.DefaultIfEmpty()
                                        where op.CodSeccionModulo.Equals(pregunta.CodSeccionModulo) && op.CodPreguntaSeccion.Equals(pregunta.CodPreguntaSeccion)
                                        select new OpcionDto
                                        {
                                            CodOpcion = op.CodOpcion,
                                            DestildaTodo = op.DestildaTodo,
                                            TextoAlternativo = op.TextoAlternativo,
                                            CodObjeto = dg2 != null && !string.IsNullOrEmpty(dg2.CodGeometrico) ? dg2.CodGeometrico : op.CodObjeto,
                                            CodColor = dg2 != null && !string.IsNullOrEmpty(dg2.CodColor) ? dg2.CodColor : null,
                                            Orden = op.Orden,
                                        }
                            ).OrderBy(op => op.Orden).ToList();
                        var codTipoDatoList = new List<string> { "COMBOPERSONAS", "CHECKBOXGROUP_PERS" };
                        if (opciones.Count > 0 && codTipoDatoList.Contains(pregunta.CodTipoDato))
                        {
                            pregunta.Opciones.AddRange(opcionesP);
                            pregunta.Opciones.AddRange(opciones);
                        }
                        else if (opciones.Count > 0)
                        {
                            pregunta.Opciones.AddRange(opciones);
                        }
                        else if (codTipoDatoList.Contains(pregunta.CodTipoDato))
                        {
                            pregunta.Opciones.AddRange(opcionesP);
                        }
                        else
                        {

                        }
                    }
                    preguntasPorSeccion.Add(seccion.CodSeccionModulo, preguntas);
                }

                return new BaseResponse<Dictionary<string, ICollection<PreguntaSeccionDto>>>(StatusCodes.Status200OK, preguntasPorSeccion);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Dictionary<string, ICollection<PreguntaSeccionDto>>>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}