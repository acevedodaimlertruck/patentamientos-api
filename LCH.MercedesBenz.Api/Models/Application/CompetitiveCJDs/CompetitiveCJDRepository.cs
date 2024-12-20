using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs
{
    public class CompetitiveCJDRepository : BaseRepository<CompetitiveCJD>, ICompetitiveCJDRepository
    {
        public CompetitiveCJDRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<CompetitiveCJDDto> GetAll2()
        {
            try
            {
                var results = Context.CompetitiveCJDs.Select(i => new CompetitiveCJDDto
                {
                    Id = i.Id,
                    MercedesCompetitiveCJD = i.MercedesCompetitiveCJD,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCompetitiveCJD).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CompetitiveCJDDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CompetitiveCJDDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
