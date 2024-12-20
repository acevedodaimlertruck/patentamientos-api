using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.WholesaleVersions
{
    public class WholesaleVersionProfile : Profile
    {
        public WholesaleVersionProfile()
        {
            CreateMap<WholesaleVersionDto, WholesaleVersion>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
