using LCH.MercedesBenz.Api.Models.Application.AltCategs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.AltCategs
{
    public interface IAltCategRepository : IBaseRepository<AltCateg>
    {
        BaseResponse<AltCategDto> GetAll2();
    }
}
