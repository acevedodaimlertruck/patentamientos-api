using AutoMapper; 
using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions.Dtos; 

namespace LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions
{
    public class Cat_InternalVersionProfile : Profile
    {
        public Cat_InternalVersionProfile()
        {
            CreateMap<Cat_InternalVersionDto, Cat_InternalVersion>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
