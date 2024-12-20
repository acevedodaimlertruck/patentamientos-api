using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CarModels
{
    public class CarModelProfile : Profile
    {
        public CarModelProfile()
        {
            CreateMap<CarModelDto, CarModel>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<CarModelDto, CarModel>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());
        }
    }
}
