using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Doors;
using LCH.MercedesBenz.Api.Models.Application.Doors.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Doors
{
    public class DoorProfile : Profile
    {
        public DoorProfile()
        {
            CreateMap<DoorDto, Door>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
