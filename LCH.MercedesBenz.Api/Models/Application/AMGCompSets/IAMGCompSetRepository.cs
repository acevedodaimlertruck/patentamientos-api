using LCH.MercedesBenz.Api.Models.Application.AMGCompSets.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.AMGCompSets
{
    public interface IAMGCompSetRepository : IBaseRepository<AMGCompSet>
    {
        BaseResponse<AMGCompSetDto> GetAll2();
    }
}
