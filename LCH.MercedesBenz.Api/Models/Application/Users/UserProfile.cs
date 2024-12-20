using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Users.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDto, User>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.Password, opt => opt.Ignore())
                .ForMember(dest => dest.Pin, opt => opt.Ignore())
                .ForMember(dest => dest.Biometric, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore());

            CreateMap<UserUpdateDto, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.UserName, opt => opt.Ignore())
                .ForMember(dest => dest.Password, opt => opt.Ignore())
                .ForMember(dest => dest.Pin, opt => opt.Ignore())
                .ForMember(dest => dest.Biometric, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore());
        }
    }
}
