using LCH.MercedesBenz.Api.Models.Application.AltBodysts.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.AltBodysts
{
    public interface IAltBodystRepository : IBaseRepository<AltBodyst>
    {
        BaseResponse<AltBodystDto> GetAll2();
    }
}
