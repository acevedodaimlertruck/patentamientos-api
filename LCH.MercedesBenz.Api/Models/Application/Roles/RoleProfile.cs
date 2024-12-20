using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Roles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Roles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleDto, Role>()
                .ForMember(dest => dest.RolePermissions, opt => opt.Ignore())
                .ForMember(dest => dest.Users, opt => opt.Ignore());

            CreateMap<RoleCreateDto, Role>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.RolePermissions, opt => opt.Ignore())
                .ForMember(dest => dest.Users, opt => opt.Ignore());

            CreateMap<RoleUpdateDto, Role>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.RolePermissions, opt => opt.Ignore())
                .ForMember(dest => dest.Users, opt => opt.Ignore());
        }
    }
}
