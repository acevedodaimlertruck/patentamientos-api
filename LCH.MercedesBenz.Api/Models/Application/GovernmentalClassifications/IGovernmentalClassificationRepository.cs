using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications
{
    public interface IGovernmentalClassificationRepository : IBaseRepository<GovernmentalClassification>
    {
        BaseResponse<GovernmentalClassificationDto> GetAll2();
    }
}
