using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.CabinCFs;
using LCH.MercedesBenz.Api.Models.Application.CabinCFs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CabinCFs
{
    public class CabinCFProfile : Profile
    {
        public CabinCFProfile()
        {
            CreateMap<CabinCFDto, CabinCF>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
