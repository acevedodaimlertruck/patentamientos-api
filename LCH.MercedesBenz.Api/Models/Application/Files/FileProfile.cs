using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Files
{
    public class FileProfile : Profile
    {
        public FileProfile()
        {
            CreateMap<FileCreateOrUpdateDto, File>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
