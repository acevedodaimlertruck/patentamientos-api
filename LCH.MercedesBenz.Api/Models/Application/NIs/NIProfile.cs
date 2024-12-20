using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.NIs;
using LCH.MercedesBenz.Api.Models.Application.NIs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.NIs
{
    public class NIProfile : Profile
    {
        public NIProfile()
        {
            CreateMap<NIDto, NI>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
