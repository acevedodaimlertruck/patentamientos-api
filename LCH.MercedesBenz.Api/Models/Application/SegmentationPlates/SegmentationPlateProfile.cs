using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationPlates
{
    public class SegmentationPlateProfile : Profile
    {
        public SegmentationPlateProfile()
        {
            CreateMap<SegmentationPlateDto, SegmentationPlate>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
