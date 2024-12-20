using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.VehicleTypes
{
    public class VehicleTypeProfile : Profile
    {
        public VehicleTypeProfile()
        {
            CreateMap<VehicleTypeDto, VehicleType>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<VehicleTypeDto, VehicleType>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<VehicleTypeDto, VehicleType>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());
        }
    }
}
