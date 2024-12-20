using LCH.MercedesBenz.Api.Models.Application.Rules.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Rules
{
    public interface IRuleRepository : IBaseRepository<Rule>
    {
        BaseResponse<RuleDto> GetAll2();

    }
}
