using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Universal.Sistemas.Dtos;
using LCH.MercedesBenz.Api.Models.Universal.TipoUsuarios.Dtos;
using System.Linq.Expressions;

namespace LCH.MercedesBenz.Api.Models.Universal.Sistemas
{
    public class SistemaRepository : BaseUniversalRepository<SistemaEntity>, ISistemaRepository
    {
        public SistemaRepository(
            UniversalDbContext context) : base(context)
        {
        }

        public BaseResponse<SistemaDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<SistemaDto>();
                Expression<Func<SistemaEntity, SistemaDto>> selector = s => new SistemaDto
                {
                    IdSistema = s.IdSistema,
                    CodSistema = s.CodSistema,
                    Sistema = s.Sistema,
                    Descripcion = s.Descripcion,
                    Prefijo = s.Prefijo,
                    PathMultimedia = s.PathMultimedia,
                    PuertoMultimedia = s.PuertoMultimedia,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.Sistemas.Select(selector).ToList();
                    return new BaseResponse<SistemaDto>(StatusCodes.Status200OK, results);
                }
                Func<SistemaDto, object> orderBy;
                switch (by)
                {
                    case "CodSistema":
                        orderBy = e => e.CodSistema;
                        break;
                    case "Sistema":
                        orderBy = e => e.Sistema;
                        break;
                    default:
                        orderBy = e => e.IdSistema;
                        break;
                }
                if (direction == Direction.Ascending)
                {
                    results = Context.Sistemas.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<SistemaDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.Sistemas.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<SistemaDto>(StatusCodes.Status200OK, results);
                }
                results = Context.Sistemas.Select(selector).ToList();
                return new BaseResponse<SistemaDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SistemaDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<SistemaDto> GetByCodUsuario(string codUsuario)
        {
            try
            {
                var results = (from s in Context.Sistemas
                               join us in Context.UsuarioSistemas on s.CodSistema equals us.CodSistema
                               join tu in Context.TipoUsuarios on new { us.CodTipoUsuario, Activo = (bool?)true } equals new { tu.CodTipoUsuario, tu.Activo } into tmpTiposUsuarios
                               from tu2 in tmpTiposUsuarios.DefaultIfEmpty()
                               where us.CodUsuario.Equals(codUsuario) && s.Activo.Equals(true) && us.Activo.Equals(true)
                               select new SistemaDto
                               {
                                   IdSistema = s.IdSistema,
                                   CodSistema = s.CodSistema,
                                   Sistema = s.Sistema,
                                   Descripcion = s.Descripcion,
                                   Prefijo = s.Prefijo,
                                   PathMultimedia = s.PathMultimedia,
                                   PuertoMultimedia = s.PuertoMultimedia,
                                   FechaRegistro = us.FechaRegistro,
                                   TipoUsuario = tu2 == null ? null : new TipoUsuarioDto
                                   {
                                       CodTipoUsuario = tu2.CodTipoUsuario,
                                       TipoUsuario = tu2.TipoUsuario,
                                   },
                               }).OrderBy(s => s.Sistema).ToList();
                return new BaseResponse<SistemaDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SistemaDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
