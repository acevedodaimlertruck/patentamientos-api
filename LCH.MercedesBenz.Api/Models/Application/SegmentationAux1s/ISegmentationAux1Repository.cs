using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s
{
    public interface ISegmentationAux1Repository : IBaseRepository<SegmentationAux1>
    {
        BaseResponse<SegmentationAux1Dto> GetAll2();
    }
}
