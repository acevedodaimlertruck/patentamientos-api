using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions
{
    public interface ICat_InternalVersionRepository : IBaseRepository<Cat_InternalVersion>
    {
        BaseResponse<Cat_InternalVersionDto> GetAll2();
        BaseResponse<Cat_InternalVersion> Create(Cat_InternalVersionDto dto);

        BaseResponse<Cat_InternalVersion> Update(Cat_InternalVersionDto dto);

        BaseResponse<int> GetLastId();
    }
}
