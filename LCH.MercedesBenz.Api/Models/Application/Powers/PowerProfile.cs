using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Powers.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Powers
{
    public class PowerProfile : Profile
    {
        public PowerProfile()
        {
            CreateMap<PowerDto, Power>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
