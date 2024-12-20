using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.RuleTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.RuleTypes
{
    public class RuleTypeProfile : Profile
    {
        public RuleTypeProfile()
        {
            CreateMap<RuleTypeCreateOrUpdateDto, RuleType>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
