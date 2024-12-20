using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Terminals
{
    public class TerminalProfile : Profile
    {
        public TerminalProfile()
        {
            CreateMap<TerminalDto, Terminal>()
                .ForMember(dest => dest.Brands, opt => opt.Ignore());

            CreateMap<TerminalDto, Terminal>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.Brands, opt => opt.Ignore());

            //CreateMap<TerminalDto, Terminal>()
            //    .ForMember(dest => dest.TMMVS, opt => opt.Ignore());
        }
    }
}
