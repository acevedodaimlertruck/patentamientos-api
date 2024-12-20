using LCH.MercedesBenz.Api.Models.Application.ApertureThrees.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureThrees
{
    public interface IApertureThreeRepository : IBaseRepository<ApertureThree>
    {
        BaseResponse<ApertureThreeDto> GetAll2();
    }
}
