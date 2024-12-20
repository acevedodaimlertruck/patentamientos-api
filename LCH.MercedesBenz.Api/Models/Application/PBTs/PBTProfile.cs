using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.PBTs;
using LCH.MercedesBenz.Api.Models.Application.PBTs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.PBTs
{
    public class PBTProfile : Profile
    {
        public PBTProfile()
        {
            CreateMap<PBTDto, PBT>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
