using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AltBodysts;
using LCH.MercedesBenz.Api.Models.Application.AltBodysts.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AltBodysts
{
    public class AltBodystProfile : Profile
    {
        public AltBodystProfile()
        {
            CreateMap<AltBodystDto, AltBodyst>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
