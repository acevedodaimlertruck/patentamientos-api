using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.WheelBases.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.WheelBases
{
    public class WheelBaseProfile : Profile
    {
        public WheelBaseProfile()
        {
            CreateMap<WheelBaseDto, WheelBase>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
