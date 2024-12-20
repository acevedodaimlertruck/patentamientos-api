using LCH.MercedesBenz.Api.Models.Application.NIs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.NIs
{
    public class NIRepository : BaseRepository<NI>, INIRepository
    {
        public NIRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<NIDto> GetAll2()
        {
            try
            {
                var results = Context.NIs.Select(i => new NIDto
                {
                    Id = i.Id,
                    MercedesNI = i.MercedesNI,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesNI).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<NIDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<NIDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
