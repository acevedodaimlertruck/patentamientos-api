using LCH.MercedesBenz.Api.Models.Application.Gears.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.Gears
{
    public class GearRepository : BaseRepository<Gear>, IGearRepository
    {
        public GearRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<GearDto> GetAll2()
        {
            try
            {
                var results = Context.Gears.Select(i => new GearDto
                {
                    Id = i.Id,
                    MercedesGear = i.MercedesGear,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesGear).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<GearDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<GearDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
