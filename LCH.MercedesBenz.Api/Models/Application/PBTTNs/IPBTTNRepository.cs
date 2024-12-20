using LCH.MercedesBenz.Api.Models.Application.PBTTNs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.PBTTNs
{
    public interface IPBTTNRepository : IBaseRepository<PBTTN>
    {
        BaseResponse<PBTTNDto> GetAll2();
    }
}
