using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations
{
    public interface IInternalVersionSegmentationRepository : IBaseRepository<InternalVersionSegmentation>
    {
        BaseResponse<InternalVersionSegmentationDto> GetAll2();

        BaseResponse<InternalVersionSegmentation> Create(InternalVersionSegmentationDto dto);
        BaseResponse<InternalVersionSegmentation> Create2(InternalVersionSegmentationCreateDto dto);

        BaseResponse<InternalVersionSegmentation> Update(InternalVersionSegmentationUpdateDto dto);

        BaseResponse<dynamic> GetCatalogs();
    }
}
