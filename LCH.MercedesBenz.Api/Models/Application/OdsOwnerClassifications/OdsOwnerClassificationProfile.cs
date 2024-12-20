using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications
{
    public class OdsOwnerClassificationProfile : Profile
    {
        public OdsOwnerClassificationProfile()
        {
            CreateMap<OdsOwnerClassificationDto, OdsOwnerClassification>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
