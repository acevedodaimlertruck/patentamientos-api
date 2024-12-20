using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AxleBases;
using LCH.MercedesBenz.Api.Models.Application.AxleBases.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AxleBases
{
    public class AxleBaseProfile : Profile
    {
        public AxleBaseProfile()
        {
            CreateMap<AxleBaseDto, AxleBase>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
