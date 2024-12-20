using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Monthlies.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Monthlies
{
    public class MonthlyProfile : Profile
    {
        public MonthlyProfile()
        {
            CreateMap<MonthlyCreateOrUpdateDto, Monthly>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
