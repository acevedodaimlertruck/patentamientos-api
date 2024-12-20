using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications
{
    public interface ISubgovernmentalClassificationRepository : IBaseRepository<SubgovernmentalClassification>
    {
        BaseResponse<SubgovernmentalClassificationDto> GetAll2();
    }
}
