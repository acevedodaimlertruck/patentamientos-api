using LCH.MercedesBenz.Api.Models.Application.NIs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.NIs
{
    public interface INIRepository : IBaseRepository<NI>
    {
        BaseResponse<NIDto> GetAll2();
    }
}
