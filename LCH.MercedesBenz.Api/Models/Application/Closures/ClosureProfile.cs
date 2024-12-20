using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Closures.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Closures
{
    public class ClosureProfile : Profile
    {
        public ClosureProfile()
        {
            CreateMap<ClosureDto, Closure>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<ClosureDto, Closure>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());
        }
    }
}
