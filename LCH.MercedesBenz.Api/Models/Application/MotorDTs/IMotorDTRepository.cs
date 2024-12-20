using LCH.MercedesBenz.Api.Models.Application.MotorDTs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.MotorDTs
{
    public interface IMotorDTRepository : IBaseRepository<MotorDT>
    {
        BaseResponse<MotorDTDto> GetAll2();
    }
}
