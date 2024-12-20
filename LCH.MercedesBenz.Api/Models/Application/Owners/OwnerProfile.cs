using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Owners.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Owners
{
    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<OwnerDto, Owner>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<OwnerDto, Owner>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());

            CreateMap<OwnerDto, Owner>()
                .ForMember(dest => dest.Patentings, opt => opt.Ignore());
        }
    }
}
