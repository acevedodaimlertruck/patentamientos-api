using LCH.MercedesBenz.Api.Models.Application.PatentingVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.WholesaleVersions
{
    public interface IWholesaleVersionRepository : IBaseRepository<WholesaleVersion>
    {
        BaseResponse<WholesaleVersionDto> GetAll2();
        BaseResponse<WholesaleVersion> Create(WholesaleVersionDto dto);

        BaseResponse<WholesaleVersion> Update(WholesaleVersionDto dto);

        BaseResponse<int> GetLastId();
    }
}
