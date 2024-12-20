using LCH.MercedesBenz.Api.Models.Application.Provinces.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Provinces
{
    public interface IProvinceRepository : IBaseRepository<Province>
    {
        BaseResponse<ProvinceDto> GetAll2();
    }
}
