using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.EventFiles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.EventFiles
{
    public class EventFileProfile : Profile
    {
        public EventFileProfile()
        {
            CreateMap<EventFileCreateOrUpdateDto, EventFile>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
