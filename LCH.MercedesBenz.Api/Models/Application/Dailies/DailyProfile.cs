using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Dailies.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Dailies
{
    public class DailyProfile : Profile
    {
        public DailyProfile()
        {
            CreateMap<DailyCreateOrUpdateDto, Daily>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
