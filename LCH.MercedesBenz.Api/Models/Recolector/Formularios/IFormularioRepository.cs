using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Formularios.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Formularios
{
    public interface IFormularioRepository : IBaseRecolectorRepository<FormularioEntity>
    {
        BaseResponse<FormularioDto> GetAll2();

        BaseResponse<Formulario2Dto> GetAll3();

        BaseResponse<FormularioDto> GetByCodOrganizaciones(List<string?> codOrganizaciones);

        BaseResponse<FormularioDto> GetByCodVersionAndCodOrganizaciones(string codVersion, List<string?> codOrganizaciones);
    }
}
