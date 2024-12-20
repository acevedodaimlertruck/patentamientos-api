using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Universal.Sistemas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Universal.Sistemas
{
    public interface ISistemaRepository : IBaseUniversalRepository<SistemaEntity>
    {
        BaseResponse<SistemaDto> GetAll(string? by = null, Direction direction = Direction.None);

        BaseResponse<SistemaDto> GetByCodUsuario(string codUsuario);
    }
}
