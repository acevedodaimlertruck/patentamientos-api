using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AperturesTwo.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesTwo
{
    public class ApertureTwoProfile : Profile
    {
        public ApertureTwoProfile()
        {
            CreateMap<ApertureTwoDto, ApertureTwo>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
