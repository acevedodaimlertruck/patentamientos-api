using LCH.MercedesBenz.Api.Models.Application;

namespace LCH.MercedesBenz.Api.Models.Universal.UsuarioOrganizaciones
{
    public interface IUsuarioOrganizacionRepository : IBaseUniversalRepository<UsuarioOrganizacionEntity>
    {
        BaseResponse<string?> GetCodOrganizaciones(string codUsuario);
    }
}
