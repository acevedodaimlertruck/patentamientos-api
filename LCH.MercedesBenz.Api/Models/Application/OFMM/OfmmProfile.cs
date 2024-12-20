using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OFMM
{
    public class OfmmProfile : Profile
    {
        public OfmmProfile()
        {
            CreateMap<OfmmDto, Ofmm>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
