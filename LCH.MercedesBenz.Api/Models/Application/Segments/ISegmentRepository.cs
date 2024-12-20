using LCH.MercedesBenz.Api.Models.Application.Segments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Segments
{
    public interface ISegmentRepository : IBaseRepository<Segment>
    {
        BaseResponse<SegmentDto> GetAll2();

        BaseResponse<Segment> Create(SegmentDto dto);

        BaseResponse<Segment> Update(SegmentDto dto);
    }
}
