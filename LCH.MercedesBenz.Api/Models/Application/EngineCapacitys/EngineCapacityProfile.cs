using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys;
using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.EngineCapacitys
{
    public class EngineCapacityProfile : Profile
    {
        public EngineCapacityProfile()
        {
            CreateMap<EngineCapacityDto, EngineCapacity>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
