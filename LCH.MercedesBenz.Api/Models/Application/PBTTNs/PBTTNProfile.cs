using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.PBTTNs;
using LCH.MercedesBenz.Api.Models.Application.PBTTNs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.PBTTNs
{
    public class PBTTNProfile : Profile
    {
        public PBTTNProfile()
        {
            CreateMap<PBTTNDto, PBTTN>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
