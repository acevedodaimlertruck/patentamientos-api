using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.EngineCapacitys
{
    public interface IEngineCapacityRepository : IBaseRepository<EngineCapacity>
    {
        BaseResponse<EngineCapacityDto> GetAll2();
    }
}
