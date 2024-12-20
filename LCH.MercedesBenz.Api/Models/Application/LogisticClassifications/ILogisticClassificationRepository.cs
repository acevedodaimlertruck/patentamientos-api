using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.LogisticClassifications
{
    public interface ILogisticClassificationRepository : IBaseRepository<LogisticClassification>
    {
        BaseResponse<LogisticClassificationDto> GetAll2();
    }
}
