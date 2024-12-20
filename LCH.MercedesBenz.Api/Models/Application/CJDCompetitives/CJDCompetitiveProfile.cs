using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives;
using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CJDCompetitives
{
    public class CJDCompetitiveProfile : Profile
    {
        public CJDCompetitiveProfile()
        {
            CreateMap<CJDCompetitiveDto, CJDCompetitive>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
