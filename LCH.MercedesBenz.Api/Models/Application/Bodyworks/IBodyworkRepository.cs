using LCH.MercedesBenz.Api.Models.Application.Bodyworks.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Bodyworks
{
    public interface IBodyworkRepository : IBaseRepository<Bodywork>
    {
        BaseResponse<BodyworkDto> GetAll2();
    }
}
