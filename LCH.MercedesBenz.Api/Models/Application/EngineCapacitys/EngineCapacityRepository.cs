using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.EngineCapacitys
{
    public class EngineCapacityRepository : BaseRepository<EngineCapacity>, IEngineCapacityRepository
    {
        public EngineCapacityRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<EngineCapacityDto> GetAll2()
        {
            try
            {
                var results = Context.EngineCapacitys.Select(i => new EngineCapacityDto
                {
                    Id = i.Id,
                    MercedesEngineCapacity = i.MercedesEngineCapacity,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesEngineCapacity).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<EngineCapacityDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<EngineCapacityDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
