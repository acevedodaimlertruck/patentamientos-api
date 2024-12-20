using LCH.MercedesBenz.Api.Models.Application;

namespace LCH.MercedesBenz.Api.Models.Universal.UsuarioOrganizaciones
{
    public class UsuarioOrganizacionRepository : BaseUniversalRepository<UsuarioOrganizacionEntity>, IUsuarioOrganizacionRepository
    {
        public UsuarioOrganizacionRepository(UniversalDbContext context) : base(context)
        {
        }

        public BaseResponse<string?> GetCodOrganizaciones(string codUsuario)
        {
            try
            {
                var results = Context.UsuarioOrganizaciones
                    .Where(e => e.Activo.Equals(true) && e.CodUsuario == codUsuario)
                    .Select(e => e.CodOrganizacion).ToList();
                return new BaseResponse<string?>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<string?>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
            }
        }
    }
}
