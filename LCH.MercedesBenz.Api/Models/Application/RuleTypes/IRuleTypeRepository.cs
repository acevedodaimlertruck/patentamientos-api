using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.RuleTypes
{
    public interface IRuleTypeRepository : IBaseRepository<RuleType>
    {
        BaseResponse<RuleTypeDto> GetAll(string? orderBy = null, Direction direction = Direction.None);

    }
}
