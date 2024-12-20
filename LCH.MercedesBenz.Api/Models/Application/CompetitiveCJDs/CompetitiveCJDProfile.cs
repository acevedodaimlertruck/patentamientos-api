using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs;
using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs
{
    public class CompetitiveCJDProfile : Profile
    {
        public CompetitiveCJDProfile()
        {
            CreateMap<CompetitiveCJDDto, CompetitiveCJD>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
