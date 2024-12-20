using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersions
{
    public class InternalVersionProfile : Profile
    {
        public InternalVersionProfile()
        {
            CreateMap<InternalVersionDto, InternalVersion>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
