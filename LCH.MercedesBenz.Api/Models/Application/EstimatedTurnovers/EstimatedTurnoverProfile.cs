using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers
{
    public class EstimatedTurnoverProfile : Profile
    {
        public EstimatedTurnoverProfile()
        {
            CreateMap<EstimatedTurnoverDto, EstimatedTurnover>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
