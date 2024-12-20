using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Brands
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandDto, Brand>()
                .ForMember(dest => dest.CarModels, opt => opt.Ignore());

            CreateMap<BrandDto, Brand>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.CarModels, opt => opt.Ignore());
        }
    }
}
