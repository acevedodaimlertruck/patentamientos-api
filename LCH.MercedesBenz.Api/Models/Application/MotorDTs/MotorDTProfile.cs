using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.MotorDTs;
using LCH.MercedesBenz.Api.Models.Application.MotorDTs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.MotorDTs
{
    public class MotorDTProfile : Profile
    {
        public MotorDTProfile()
        {
            CreateMap<MotorDTDto, MotorDT>()
                .ForMember(dest => dest.AutoId, act => act.MapFrom(src => 0));
        }
    }
}
