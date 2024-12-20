using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Sources;
using LCH.MercedesBenz.Api.Models.Application.Sources.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Sources
{
    public class SourceProfile : Profile
    {
        public SourceProfile()
        {
            CreateMap<SourceDto, Source>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
