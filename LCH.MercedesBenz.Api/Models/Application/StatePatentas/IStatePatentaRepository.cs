using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.StatePatentas
{
    public interface IStatePatentaRepository : IBaseRepository<StatePatenta>
    {
        BaseResponse<StatePatentaDto> GetAll(string? orderBy = null, Direction direction = Direction.None);

    }
}
