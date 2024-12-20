using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.KeyVersions
{
    public class KeyVersionProfile : Profile
    {
        public KeyVersionProfile()
        {
            CreateMap<KeyVersionDto, KeyVersion>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
