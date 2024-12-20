using LCH.MercedesBenz.Api.Models.Application.CuitClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CuitClassifications
{
    public interface ICuitClassificationRepository : IBaseRepository<CuitClassification>
    {
        BaseResponse<CuitClassificationDto> GetAll2();
    }
}
