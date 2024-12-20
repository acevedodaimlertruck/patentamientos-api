using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s;
using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s
{
    public class SegmentationAux1Profile : Profile
    {
        public SegmentationAux1Profile()
        {
            CreateMap<SegmentationAux1Dto, SegmentationAux1>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
