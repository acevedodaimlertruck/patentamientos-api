using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.CJDCompetitives
{
    public interface ICJDCompetitiveRepository : IBaseRepository<CJDCompetitive>
    {
        BaseResponse<CJDCompetitiveDto> GetAll2();
    }
}
