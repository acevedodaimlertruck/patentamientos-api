using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications
{
    public class SubgovernmentalClassificationProfile : Profile
    {
        public SubgovernmentalClassificationProfile()
        {
            CreateMap<SubgovernmentalClassificationDto, SubgovernmentalClassification>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
