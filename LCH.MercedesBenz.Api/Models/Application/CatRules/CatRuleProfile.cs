using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.CatRules;
using LCH.MercedesBenz.Api.Models.Application.CatRules.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CatRules
{
    public class CatRuleProfile : Profile
    {
        public CatRuleProfile()
        {
            CreateMap<CatRuleDto, CatRule>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
