using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.AperturesOne.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesOne
{
    public class ApertureOneProfile : Profile
    {
        public ApertureOneProfile()
        {
            CreateMap<ApertureOneDto, ApertureOne>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
