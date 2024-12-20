using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs
{
    public interface ICompetitiveCJDRepository : IBaseRepository<CompetitiveCJD>
    {
        BaseResponse<CompetitiveCJDDto> GetAll2();
    }
}
