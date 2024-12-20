using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.StatePatentas
{
    public class StatePatentaProfile : Profile
    {
        public StatePatentaProfile()
        {
            CreateMap<StatePatentaCreateOrUpdateDto, StatePatenta>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
