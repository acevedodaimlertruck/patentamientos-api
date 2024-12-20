using LCH.MercedesBenz.Api.Models.Application.AMGCompSets.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.AMGCompSets
{
    public class AMGCompSetRepository : BaseRepository<AMGCompSet>, IAMGCompSetRepository
    {
        public AMGCompSetRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<AMGCompSetDto> GetAll2()
        {
            try
            {
                var results = Context.AMGCompSets.Select(i => new AMGCompSetDto
                {
                    Id = i.Id,
                    MercedesAMGCompSet = i.MercedesAMGCompSet,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAMGCompSet).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<AMGCompSetDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<AMGCompSetDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
