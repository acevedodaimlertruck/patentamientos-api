using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Bodyworks.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Bodyworks
{
    public class BodyworkProfile : Profile
    {
        public BodyworkProfile()
        {
            CreateMap<BodyworkDto, Bodywork>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
