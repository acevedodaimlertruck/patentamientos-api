using LCH.MercedesBenz.Api.Models.Application.Configurations.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Configurations
{
    public interface IConfigurationRepository : IBaseRepository<Configuration>
    {
        BaseResponse<ConfigurationDto> GetAll2();
    }
}
