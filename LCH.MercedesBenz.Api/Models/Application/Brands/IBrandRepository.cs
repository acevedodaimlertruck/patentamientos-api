using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Brands
{
    public interface IBrandRepository : IBaseRepository<Brand>
    {
        BaseResponse<BrandDto> GetAll2();

        BaseResponse<Brand> Create(BrandDto dto);

        BaseResponse<Brand> Update(BrandDto dto);

        dynamic addJson(dynamic json);
    }
}
