using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.TMMVS.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.TMMVS
{
    public class TMMVProfile : Profile
    {
        public TMMVProfile()
        {
            CreateMap<TMMVDto, TMMV>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
