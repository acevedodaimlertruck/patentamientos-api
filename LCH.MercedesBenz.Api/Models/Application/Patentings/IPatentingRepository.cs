using LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Patentings
{
    public interface IPatentingRepository : IBaseRepository<Patenting>
    {
        BaseResponse<PatentingDto> GetAll2();

        BaseResponse<dynamic> GetPatentingByFileId(Guid fileId);

        BaseResponse<dynamic> GetAllPatentings();

        BaseResponse<PatentingDto> GetPatentingsFiltered(string? dateFrom, string? dateTo, bool? lastDischarge, string? errorType, string? fileId);

        BaseResponse<PatentingDto> GetPatentingById(Guid patentingId);

        BaseResponse<Patenting> SavePatenting(PatentingUpdateDto patentingDto);

        BaseResponse<dynamic> GetRulesPatentingById(Guid patentingId);

        BaseResponse<dynamic> ProcessByFileId(Guid fileId, Guid fileTypeId, Guid? wsID);

        BaseResponse<dynamic> SaveByPatentingId(Guid patentingId);

        BaseResponse<dynamic> FixErrorOfmm(string ofmm);

        BaseResponse<dynamic> GetLastFilePatenting();
    }
}
