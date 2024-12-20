using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AltSegms;
using LCH.MercedesBenz.Api.Models.Application.AltSegms.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AltSegms
{
    public class AltSegmProfile : Profile
    {
        public AltSegmProfile()
        {
            CreateMap<AltSegmDto, AltSegm>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
