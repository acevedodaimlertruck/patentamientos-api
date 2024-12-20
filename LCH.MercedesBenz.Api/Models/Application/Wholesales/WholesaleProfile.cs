using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Wholesales.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Wholesales
{
    public class WholesaleProfile : Profile
    {
        public WholesaleProfile()
        {
            CreateMap<WholesaleCreateOrUpdateDto, Wholesale>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
