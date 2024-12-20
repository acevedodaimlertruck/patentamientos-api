using LCH.MercedesBenz.Api.Models.Application.SSegms.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.SSegms
{
    public interface ISSegmRepository : IBaseRepository<SSegm>
    {
        BaseResponse<SSegmDto> GetAll2();
    }
}
