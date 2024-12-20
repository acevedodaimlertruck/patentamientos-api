using LCH.MercedesBenz.Api.Models.Application.AltSegms.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.AltSegms
{
    public interface IAltSegmRepository : IBaseRepository<AltSegm>
    {
        BaseResponse<AltSegmDto> GetAll2();
    }
}
