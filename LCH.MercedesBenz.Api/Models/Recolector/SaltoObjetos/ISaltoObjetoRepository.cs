using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.SaltoObjetos
{
    public interface ISaltoObjetoRepository : IBaseRecolectorRepository<SaltoObjetoEntity>
    {
        BaseResponse<SaltoObjetoDto> GetByCodVersion(string codVersion);

        BaseResponse<ValidacionSimpleDto> GetValidacionesSimplesByCodVersion(string codVersion);
    }
}
