using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Versiones
{
    public interface IVersionRepository : IBaseRecolectorRepository<VersionEntity>
    {
        BaseResponse<VersionDto> GetAll2();

        BaseResponse<VersionDto> GetByCodFormulario(string codFormulario);

        BaseResponse<VersionEntity> GetByCodFormularioAndCodVersion(string codFormulario, string codVersion);
    }
}
