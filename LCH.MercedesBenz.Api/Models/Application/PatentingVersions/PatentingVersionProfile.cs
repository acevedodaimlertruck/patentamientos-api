using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.PatentingVersions
{
    public class PatentingVersionProfile : Profile
    {
        public PatentingVersionProfile()
        {
            CreateMap<PatentingVersionDto, PatentingVersion>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
