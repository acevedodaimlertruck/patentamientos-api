using LCH.MercedesBenz.Api.Models.Application.Subsegments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Subsegments
{
    public interface ISubsegmentRepository : IBaseRepository<Subsegment>
    {
        BaseResponse<SubsegmentDto> GetAll2();
    }
}
