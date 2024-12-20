using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.RegSecs
{
    public class RegSecProfile : Profile
    {
        public RegSecProfile()
        {
            CreateMap<RegSecDto, RegSec>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
