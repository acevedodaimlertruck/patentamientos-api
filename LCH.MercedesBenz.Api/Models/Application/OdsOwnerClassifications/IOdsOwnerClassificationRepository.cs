using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications
{
    public interface IOdsOwnerClassificationRepository : IBaseRepository<OdsOwnerClassification>
    {
        BaseResponse<OdsOwnerClassificationDto> GetAll2();

        BaseResponse<OdsOwnerClassification> Create(OdsOwnerClassificationDto dto);

        BaseResponse<OdsOwnerClassification> Update(OdsOwnerClassificationDto dto);
    }
}
