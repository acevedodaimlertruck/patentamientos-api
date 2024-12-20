using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Gears;
using LCH.MercedesBenz.Api.Models.Application.Gears.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Gears
{
    public class GearProfile : Profile
    {
        public GearProfile()
        {
            CreateMap<GearDto, Gear>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
