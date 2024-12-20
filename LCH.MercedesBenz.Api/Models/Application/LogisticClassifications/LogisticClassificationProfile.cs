using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.LogisticClassifications
{
    public class LogisticClassificationProfile : Profile
    {
        public LogisticClassificationProfile()
        {
            CreateMap<LogisticClassificationDto, LogisticClassification>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
