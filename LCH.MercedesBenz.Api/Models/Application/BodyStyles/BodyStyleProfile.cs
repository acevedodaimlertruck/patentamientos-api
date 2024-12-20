using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.BodyStyles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.BodyStyles
{
    public class BodyStyleProfile : Profile
    {
        public BodyStyleProfile()
        {
            CreateMap<BodyStyleDto, BodyStyle>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
