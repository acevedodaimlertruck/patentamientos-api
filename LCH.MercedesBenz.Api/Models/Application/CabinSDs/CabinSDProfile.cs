using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.CabinSDs;
using LCH.MercedesBenz.Api.Models.Application.CabinSDs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CabinSDs
{
    public class CabinSDProfile : Profile
    {
        public CabinSDProfile()
        {
            CreateMap<CabinSDDto, CabinSD>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
