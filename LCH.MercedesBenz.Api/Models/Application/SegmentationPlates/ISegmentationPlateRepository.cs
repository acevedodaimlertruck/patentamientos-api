using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationPlates
{
    public interface ISegmentationPlateRepository : IBaseRepository<SegmentationPlate>
    {
        BaseResponse<SegmentationPlateDto> GetAll2();

        BaseResponse<dynamic> ProcessSegmentations(string? dateFrom, string? dateTo, Guid? fileId, Guid? patentaId);

        BaseResponse<SegmentationPlateDto> GetSegmentationsByCategory(string category);

        BaseResponse<SegmentationPlateDto> GetSegmentationsByFileId(Guid fileId);

    }
}
