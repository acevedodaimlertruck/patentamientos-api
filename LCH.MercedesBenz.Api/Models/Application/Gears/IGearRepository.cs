using LCH.MercedesBenz.Api.Models.Application.Gears.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Gears
{
    public interface IGearRepository : IBaseRepository<Gear>
    {
        BaseResponse<GearDto> GetAll2();
    }
}
