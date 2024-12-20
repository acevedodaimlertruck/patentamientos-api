using LCH.MercedesBenz.Api.Models.Application.Configurations.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.Configurations
{
    public class ConfigurationRepository : BaseRepository<Configuration>, IConfigurationRepository
    {
        public ConfigurationRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<ConfigurationDto> GetAll2()
        {
            try
            {
                var results = Context.Configurations.Select(i => new ConfigurationDto
                {
                    Id = i.Id,
                    MercedesConfiguration = i.MercedesConfiguration,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesConfiguration).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<ConfigurationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ConfigurationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
