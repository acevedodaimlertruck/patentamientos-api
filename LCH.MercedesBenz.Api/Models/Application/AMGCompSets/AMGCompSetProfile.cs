using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AMGCompSets;
using LCH.MercedesBenz.Api.Models.Application.AMGCompSets.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AMGCompSets
{
    public class AMGCompSetProfile : Profile
    {
        public AMGCompSetProfile()
        {
            CreateMap<AMGCompSetDto, AMGCompSet>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
