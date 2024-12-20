using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications
{
    public class GovernmentalClassificationProfile : Profile
    {
        public GovernmentalClassificationProfile()
        {
            CreateMap<GovernmentalClassificationDto, GovernmentalClassification>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
