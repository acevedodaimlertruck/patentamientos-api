using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.FechaCierres.Dtos;
using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.FechaCierres
{
    public class FechaCierreProfile : Profile
    {
        public FechaCierreProfile()
        {
            CreateMap<FechaCierreCreateOrUpdateDto, FechaCierre>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
