using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Formularios.Dtos;

namespace LCH.MercedesBenz.Api.Services.Recolector.Formularios
{
    public interface IFormularioService
    {
        BaseResponse<FormularioDto> GetByCodUsuario(string codUsuario);

        BaseResponse<FormularioDto> GetByCodUsuarioAndCodVersion(string codUsuario, string codVersion);
    }
}
