using LCH.MercedesBenz.Api.Models.Application.SecurityParameters.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SecurityParameters
{
    public interface ISecurityParameterRepository : IBaseRepository<SecurityParameter>
    {
        BaseResponse<SecurityParameterDto> GetAll2(bool dispose = true);
    }
}
