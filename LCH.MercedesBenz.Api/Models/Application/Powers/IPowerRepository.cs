using LCH.MercedesBenz.Api.Models.Application.Owners;
using LCH.MercedesBenz.Api.Models.Application.Powers.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Powers
{
    public interface IPowerRepository : IBaseRepository<Power>
    {
        BaseResponse<PowerDto> GetAll2();
    }
}
