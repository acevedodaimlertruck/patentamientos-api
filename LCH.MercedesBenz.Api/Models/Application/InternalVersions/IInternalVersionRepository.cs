using LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersions
{
    public interface IInternalVersionRepository : IBaseRepository<InternalVersion>
    {
        BaseResponse<InternalVersionDto> GetAll2();

        BaseResponse<InternalVersion> Create(InternalVersionDto dto);

        BaseResponse<InternalVersion> Update(InternalVersionDto dto);

        BaseResponse<int> GetLastId();
    }
}
