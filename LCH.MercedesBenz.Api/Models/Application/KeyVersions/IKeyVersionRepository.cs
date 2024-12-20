using LCH.MercedesBenz.Api.Models.Application.KeyVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.KeyVersions
{
    public interface IKeyVersionRepository : IBaseRepository<KeyVersion>
    {
        BaseResponse<KeyVersionDto> GetAll2();

        BaseResponse<KeyVersion> Create(KeyVersionDto dto);

        BaseResponse<KeyVersion> Update(KeyVersionDto dto);
    }
}
