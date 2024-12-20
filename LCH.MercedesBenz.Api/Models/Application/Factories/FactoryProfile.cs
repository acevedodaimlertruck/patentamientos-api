using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Factories
{
    public class FactoryProfile : Profile
    {
        public FactoryProfile()
        {
            CreateMap<FactoryDto, Factory>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<FactoryDto, Factory>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<FactoryDto, Factory>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());
        }
    }
}
