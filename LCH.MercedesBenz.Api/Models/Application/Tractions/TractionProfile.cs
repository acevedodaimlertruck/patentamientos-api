using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Tractions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Tractions
{
    public class TractionProfile : Profile
    {
        public TractionProfile()
        {
            CreateMap<TractionDto, Traction>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
