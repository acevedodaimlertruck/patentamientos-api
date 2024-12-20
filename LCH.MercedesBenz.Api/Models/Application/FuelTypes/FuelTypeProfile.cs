using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.FuelTypes
{
    public class FuelTypeProfile : Profile
    {
        public FuelTypeProfile()
        {
            CreateMap<FuelTypeDto, FuelType>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
