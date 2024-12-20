using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.FileTypes
{
    public class FileTypeProfile : Profile
    {
        public FileTypeProfile()
        {
            CreateMap<FileTypeCreateOrUpdateDto, FileType>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
