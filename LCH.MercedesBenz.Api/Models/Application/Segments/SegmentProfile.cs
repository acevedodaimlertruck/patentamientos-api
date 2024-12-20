using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Segments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Segments
{
    public class SegmentProfile : Profile
    {
        public SegmentProfile()
        {
            CreateMap<SegmentDto, Segment>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
