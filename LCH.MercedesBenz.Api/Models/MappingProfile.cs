using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions;
using LCH.MercedesBenz.Api.Models.Application.PatentingVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RegSecs;
using LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions;
using LCH.MercedesBenz.Api.Models.Application.WholesaleVersions.Dtos;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegSecDto, RegSec>();
        CreateMap<RegSec, RegSecDto>();
        CreateMap<PatentingVersion, PatentingVersionDto>();
        CreateMap<PatentingVersionDto, PatentingVersion>();
        CreateMap<WholesaleVersion, WholesaleVersionDto>();
        CreateMap<WholesaleVersionDto, WholesaleVersion>();
    }
}