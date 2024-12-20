using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Usages.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Usages
{
    public class UsageProfile : Profile
    {
        public UsageProfile()
        {
            CreateMap<UsageDto, Usage>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
