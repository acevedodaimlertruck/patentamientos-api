using LCH.MercedesBenz.Api.Models.Application.RelevMBs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.RelevMBs
{
    public interface IRelevMBRepository : IBaseRepository<RelevMB>
    {
        BaseResponse<RelevMBDto> GetAll2();
    }
}
