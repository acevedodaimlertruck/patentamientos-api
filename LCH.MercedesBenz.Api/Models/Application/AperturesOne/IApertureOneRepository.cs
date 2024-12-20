using LCH.MercedesBenz.Api.Models.Application.AperturesOne.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesOne
{
    public interface IApertureOneRepository : IBaseRepository<ApertureOne>
    {
        BaseResponse<ApertureOneDto> GetAll2();
    }
}
