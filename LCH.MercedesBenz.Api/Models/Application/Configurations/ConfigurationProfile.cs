using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Configurations;
using LCH.MercedesBenz.Api.Models.Application.Configurations.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Configurations
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<ConfigurationDto, Configuration>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
