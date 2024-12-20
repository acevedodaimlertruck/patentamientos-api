using LCH.MercedesBenz.Api.Models.Application.WheelBases.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.WheelBases
{
    public interface IWheelBaseRepository : IBaseRepository<WheelBase>
    {
        BaseResponse<WheelBaseDto> GetAll2();
    }
}
