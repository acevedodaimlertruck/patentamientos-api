using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.ValidacionComplejas
{
    public interface IValidacionComplejaRepository : IBaseRecolectorRepository<ValidacionComplejaEntity>
    {
        BaseResponse<ValidacionComplejaDto> GetByCodVersion(string codVersion);
    }
}
