using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AltCategs;
using LCH.MercedesBenz.Api.Models.Application.AltCategs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AltCategs
{
    public class AltCategProfile : Profile
    {
        public AltCategProfile()
        {
            CreateMap<AltCategDto, AltCateg>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
