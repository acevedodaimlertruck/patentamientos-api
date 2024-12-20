using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Versiones
{
    public class VersionRepository : BaseRecolectorRepository<VersionEntity>, IVersionRepository
    {
        public VersionRepository(RecolectorDbContext context) : base(context)
        {
        }

        public BaseResponse<VersionDto> GetAll2()
        {
            try
            {
                var results = (from v in Context.Versiones
                               where v.Activo.Equals(true)
                               select new VersionDto
                               {
                                   CodVersion = v.CodVersion,
                                   CodFormulario = v.CodFormulario,
                                   Version = v.Version,
                                   FechaRegistro = v.FechaRegistro,
                                   Js = v.Js,
                                   Activo = v.Activo,
                               }).OrderByDescending(v => v.FechaRegistro).ToList();
                return new BaseResponse<VersionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<VersionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<VersionDto> GetByCodFormulario(string codFormulario)
        {
            try
            {
                var results = (from v in Context.Versiones
                               where v.CodFormulario == codFormulario && v.Activo.Equals(true)
                               select new VersionDto
                               {
                                   CodVersion = v.CodVersion,
                                   CodFormulario = v.CodFormulario,
                                   Version = v.Version,
                                   FechaRegistro = v.FechaRegistro,
                                   Js = v.Js,
                                   Activo = v.Activo
                               }).OrderByDescending(v => v.FechaRegistro).ToList();
                return new BaseResponse<VersionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<VersionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<VersionEntity> GetByCodFormularioAndCodVersion(string codFormulario, string codVersion)
        {
            try
            {
                var result = (from v in Context.Versiones
                              where v.CodFormulario == codFormulario && v.CodVersion.Equals(codVersion)
                              select v).SingleOrDefault();
                return new BaseResponse<VersionEntity>(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return new BaseResponse<VersionEntity>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
