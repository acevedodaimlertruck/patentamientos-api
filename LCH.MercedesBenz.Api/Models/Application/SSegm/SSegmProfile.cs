using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.SSegms;
using LCH.MercedesBenz.Api.Models.Application.SSegms.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SSegms
{
    public class SSegmProfile : Profile
    {
        public SSegmProfile()
        {
            CreateMap<SSegmDto, SSegm>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
