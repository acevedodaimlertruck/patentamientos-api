using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Rules.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Rules
{
    public class RuleProfile : Profile
    {
        public RuleProfile()
        {
            CreateMap<RuleCreateOrUpdateDto, Rule>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
