using LCH.MercedesBenz.Api.Models.Application.BodyStyles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.BodyStyles
{
    public interface IBodyStyleRepository : IBaseRepository<BodyStyle>
    {
        BaseResponse<BodyStyleDto> GetAll2();
    }
}
