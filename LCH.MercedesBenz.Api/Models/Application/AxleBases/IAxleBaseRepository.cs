using LCH.MercedesBenz.Api.Models.Application.AxleBases.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.AxleBases
{
    public interface IAxleBaseRepository : IBaseRepository<AxleBase>
    {
        BaseResponse<AxleBaseDto> GetAll2();
    }
}
