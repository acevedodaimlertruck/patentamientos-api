using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts;
using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts
{
    public class MCGTotalMktProfile : Profile
    {
        public MCGTotalMktProfile()
        {
            CreateMap<MCGTotalMktDto, MCGTotalMkt>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
