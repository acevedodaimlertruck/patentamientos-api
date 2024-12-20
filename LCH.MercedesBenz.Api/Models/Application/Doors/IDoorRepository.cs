using LCH.MercedesBenz.Api.Models.Application.Doors.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Doors
{
    public interface IDoorRepository : IBaseRepository<Door>
    {
        BaseResponse<DoorDto> GetAll2();
    }
}
