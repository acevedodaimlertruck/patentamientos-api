using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Categories.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
