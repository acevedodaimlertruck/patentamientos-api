using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Patentings
{
    public class PatentingProfile : Profile
    {
        public PatentingProfile()
        {
            CreateMap<PatentingDto, Patenting>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.RulePatentings, opt => opt.Ignore()); ;

            CreateMap<PatentingUpdateDto, Patenting>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.RulePatentings, opt => opt.Ignore()); ;
        }
    }
}
