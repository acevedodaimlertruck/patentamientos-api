using LCH.MercedesBenz.Api.Models.Application.Sources.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Sources
{
    public interface ISourceRepository : IBaseRepository<Source>
    {
        BaseResponse<SourceDto> GetAll2();
    }
}
