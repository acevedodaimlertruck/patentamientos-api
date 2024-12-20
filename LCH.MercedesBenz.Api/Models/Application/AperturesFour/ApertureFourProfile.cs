using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.ApertureFours;
using LCH.MercedesBenz.Api.Models.Application.ApertureFours.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureFours
{
    public class ApertureFourProfile : Profile
    {
        public ApertureFourProfile()
        {
            CreateMap<ApertureFourDto, ApertureFour>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
