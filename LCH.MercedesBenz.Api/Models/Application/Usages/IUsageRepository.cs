using LCH.MercedesBenz.Api.Models.Application.Usages.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Usages
{
    public interface IUsageRepository : IBaseRepository<Usage>
    {
        BaseResponse<UsageDto> GetAll2();
    }
}
