using LCH.MercedesBenz.Api.Models.Application.Categories.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Categories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        BaseResponse<CategoryDto> GetAll2();

        BaseResponse<Category> Create(CategoryDto dto);

        BaseResponse<Category> Update(CategoryDto dto);
    }
}
