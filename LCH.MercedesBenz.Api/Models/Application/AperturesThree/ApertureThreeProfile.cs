using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.ApertureThrees;
using LCH.MercedesBenz.Api.Models.Application.ApertureThrees.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureThrees
{
    public class ApertureThreeProfile : Profile
    {
        public ApertureThreeProfile()
        {
            CreateMap<ApertureThreeDto, ApertureThree>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
