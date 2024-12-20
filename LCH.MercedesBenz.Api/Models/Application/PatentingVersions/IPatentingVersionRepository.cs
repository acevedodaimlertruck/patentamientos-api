using LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.PatentingVersions
{
    public interface IPatentingVersionRepository : IBaseRepository<PatentingVersion>
    {
        BaseResponse<PatentingVersionDto> GetAll2();
        BaseResponse<PatentingVersion> Create(PatentingVersionDto dto);

        BaseResponse<PatentingVersion> Update(PatentingVersionDto dto);

        BaseResponse<int> GetLastId();
    }
}
