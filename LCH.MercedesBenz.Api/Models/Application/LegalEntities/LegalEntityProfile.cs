using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.LegalEntities.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.LegalEntities
{
    public class LegalEntityProfile : Profile
    {
        public LegalEntityProfile()
        {
            CreateMap<LegalEntityDto, LegalEntity>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
