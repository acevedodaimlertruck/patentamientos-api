using LCH.MercedesBenz.Api.Models.Application.Doors.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.Doors
{
    public class DoorRepository : BaseRepository<Door>, IDoorRepository
    {
        public DoorRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<DoorDto> GetAll2()
        {
            try
            {
                var results = Context.Doors.Select(i => new DoorDto
                {
                    Id = i.Id,
                    MercedesDoor = i.MercedesDoor,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesDoor).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<DoorDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<DoorDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
