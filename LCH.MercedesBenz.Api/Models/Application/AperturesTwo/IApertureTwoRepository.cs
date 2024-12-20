using LCH.MercedesBenz.Api.Models.Application.AperturesTwo.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesTwo
{
    public interface IApertureTwoRepository : IBaseRepository<ApertureTwo>
    {
        BaseResponse<ApertureTwoDto> GetAll2();
    }
}
