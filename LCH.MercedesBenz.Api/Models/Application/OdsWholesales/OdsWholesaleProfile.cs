using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OdsWholesales
{
    public class OdsWholesaleProfile : Profile
    {
        public OdsWholesaleProfile()
        {
            CreateMap<OdsWholesaleDto, OdsWholesale>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
