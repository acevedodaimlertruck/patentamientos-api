using System.Data;
using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Formularios.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.Modulos.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.Secciones.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.SeccionModulos.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos;
using StoredProcedureEFCore;

namespace LCH.MercedesBenz.Api.Models.Recolector.Formularios
{
    public class FormularioRepository : BaseRecolectorRepository<FormularioEntity>, IFormularioRepository
    {
        public FormularioRepository(RecolectorDbContext context) : base(context)
        {
        }

        public BaseResponse<FormularioDto> GetAll2()
        {
            try
            {
                var query = (from f in Context.Formularios
                             join v in Context.Versiones on f.CodFormulario equals v.CodFormulario
                             where f.Activo == true && v.Activo == true
                             select new FormularioDto
                             {
                                 IdFormulario = f.IdFormulario,
                                 CodFormulario = f.CodFormulario,
                                 CodSistemaOrigen = f.CodSistemaOrigen,
                                 Formulario = f.Formulario,
                                 FechaRegistro = f.FechaRegistro,
                                 Descripcion = f.Descripcion,
                                 Prefijo = f.Prefijo,
                                 CodOrganizacion = f.CodOrganizacion,
                                 Version = new VersionDto
                                 {
                                     CodVersion = v.CodVersion,
                                     CodFormulario = v.CodFormulario,
                                     Version = v.Version,
                                     Descripcion = v.Descripcion,
                                     FechaRegistro = v.FechaRegistro,
                                     CodTipoRelevamiento = v.CodTipoRelevamiento,
                                 }
                             });
                var results = query.OrderBy(e => e.Formulario).ToList();
                return new BaseResponse<FormularioDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FormularioDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<Formulario2Dto> GetAll3()
        {
            try
            {
                List<Formulario2Dto> results = new List<Formulario2Dto>();
                Context.LoadStoredProc("[dbo].[usp_Formulario]")
                    .AddParam("Comando", "SelectAll")
                    .Exec(action => results = action.ToList<Formulario2Dto>());
                return new BaseResponse<Formulario2Dto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Formulario2Dto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<FormularioDto> GetByCodOrganizaciones(List<string?> codOrganizaciones)
        {
            try
            {
                var query = (from f in Context.Formularios
                             join v in Context.Versiones on f.CodFormulario equals v.CodFormulario
                             where f.Activo == true && v.Activo == true && codOrganizaciones.Contains(f.CodOrganizacion)
                             select new FormularioDto
                             {
                                 IdFormulario = f.IdFormulario,
                                 CodFormulario = f.CodFormulario,
                                 CodSistemaOrigen = f.CodSistemaOrigen,
                                 Formulario = f.Formulario,
                                 Descripcion = f.Descripcion,
                                 FechaRegistro = f.FechaRegistro,
                                 Prefijo = f.Prefijo,
                                 CodOrganizacion = f.CodOrganizacion,
                                 Version = new VersionDto
                                 {
                                     CodVersion = v.CodVersion,
                                     CodFormulario = v.CodFormulario,
                                     Version = v.Version,
                                     Descripcion = v.Descripcion,
                                     FechaRegistro = v.FechaRegistro,
                                     CodTipoRelevamiento = v.CodTipoRelevamiento,
                                 }
                             });
                var results = query.OrderBy(e => e.Formulario).ToList();
                return new BaseResponse<FormularioDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FormularioDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<FormularioDto> GetByCodVersionAndCodOrganizaciones(string codVersion, List<string?> codOrganizaciones)
        {
            try
            {
                var query = (from f in Context.Formularios
                             join v in Context.Versiones on f.CodFormulario equals v.CodFormulario
                             where f.Activo == true && v.Activo == true && v.CodVersion.Equals(codVersion) && codOrganizaciones.Contains(f.CodOrganizacion)
                             select new FormularioDto
                             {
                                 IdFormulario = f.IdFormulario,
                                 CodFormulario = f.CodFormulario,
                                 CodSistemaOrigen = f.CodSistemaOrigen,
                                 Formulario = f.Formulario,
                                 Descripcion = f.Descripcion,
                                 FechaRegistro = f.FechaRegistro,
                                 Prefijo = f.Prefijo,
                                 CodOrganizacion = f.CodOrganizacion,
                                 Version = new VersionDto
                                 {
                                     CodVersion = v.CodVersion,
                                     CodFormulario = v.CodFormulario,
                                     Version = v.Version,
                                     Descripcion = v.Descripcion,
                                     FechaRegistro = v.FechaRegistro,
                                     CodTipoRelevamiento = v.CodTipoRelevamiento,
                                 }
                             });
                var formulario = query.FirstOrDefault();
                if (formulario == null || formulario.Version == null)
                    return new BaseResponse<FormularioDto>(StatusCodes.Status400BadRequest, "Form not found.");
                var modulos = Context.Modulos
                    .Where(e => e.Activo == true && e.CodVersion.Equals(formulario.Version.CodVersion))
                    .Select(e => new ModuloDto
                    {
                        IdModulo = e.IdModulo,
                        CodModulo = e.CodModulo,
                        CodVersion = e.CodVersion,
                        Modulo = e.Modulo,
                        Descripcion = e.Descripcion,
                        Orden = e.Orden,
                        ConHistorial = e.ConHistorial,
                        CodObjeto = e.CodObjeto,
                        SeccionesModulo = (from s in Context.Secciones
                                           join sm in Context.SeccionModulos on s.CodSeccion equals sm.CodSeccion
                                           where s.Activo == true && sm.Activo == true && sm.CodModulo.Equals(e.CodModulo)
                                           select new SeccionModuloDto
                                           {
                                               CodSeccionModulo = sm.CodSeccionModulo,
                                               CodSeccion = sm.CodSeccion,
                                               CodModulo = sm.CodModulo,
                                               Obligatoria = sm.Obligatoria,
                                               Visible = sm.Visible,
                                               Orden = sm.Orden,
                                               CodObjeto = sm.CodObjeto,
                                               CantBloques = sm.CantBloques,
                                               TextoAlternativo = sm.TextoAlternativo,
                                               Seccion = new SeccionDto
                                               {
                                                   CodSeccion = s.CodSeccion,
                                                   Seccion = s.Seccion,
                                                   Descripcion = s.Descripcion,
                                               },
                                           }).OrderBy(sm => sm.Orden).ToList(),
                    }).OrderBy(e => e.Orden).ToList();
                formulario.Modulos = modulos;
                return new BaseResponse<FormularioDto>(StatusCodes.Status200OK, formulario);
            }
            catch (Exception ex)
            {
                return new BaseResponse<FormularioDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
