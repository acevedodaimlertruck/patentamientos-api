using LCH.MercedesBenz.Api.Models.Application.CatRules.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.CatRules
{
    public interface ICatRuleRepository : IBaseRepository<CatRule>
    {
        BaseResponse<CatRuleDto> GetAll2();
    }
}
