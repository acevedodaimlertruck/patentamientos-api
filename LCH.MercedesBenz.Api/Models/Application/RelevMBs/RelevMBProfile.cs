using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.RelevMBs;
using LCH.MercedesBenz.Api.Models.Application.RelevMBs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.RelevMBs
{
    public class RelevMBProfile : Profile
    {
        public RelevMBProfile()
        {
            CreateMap<RelevMBDto, RelevMB>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
