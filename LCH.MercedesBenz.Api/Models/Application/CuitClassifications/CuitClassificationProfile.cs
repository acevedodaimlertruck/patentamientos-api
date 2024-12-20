using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.CuitClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CuitClassifications
{
    public class CuitClassificationProfile : Profile
    {
        public CuitClassificationProfile()
        {
            CreateMap<CuitClassificationDto, CuitClassification>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
