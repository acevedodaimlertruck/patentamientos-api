using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Groups;
using LCH.MercedesBenz.Api.Models.Application.Groups.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Groups
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<GroupDto, Group>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
