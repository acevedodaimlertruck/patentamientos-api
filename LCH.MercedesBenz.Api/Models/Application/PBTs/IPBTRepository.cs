using LCH.MercedesBenz.Api.Models.Application.PBTs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.PBTs
{
    public interface IPBTRepository : IBaseRepository<PBT>
    {
        BaseResponse<PBTDto> GetAll2();
    }
}
