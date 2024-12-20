using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Subsegments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Subsegments
{
    public class SubsegmentProfile : Profile
    {
        public SubsegmentProfile()
        {
            CreateMap<SubsegmentDto, Subsegment>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
