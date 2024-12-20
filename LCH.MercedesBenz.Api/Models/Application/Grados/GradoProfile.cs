using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Grados.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Grados
{
    public class GradoProfile : Profile
    {
        public GradoProfile()
        {
            CreateMap<GradoDto, Grado>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
