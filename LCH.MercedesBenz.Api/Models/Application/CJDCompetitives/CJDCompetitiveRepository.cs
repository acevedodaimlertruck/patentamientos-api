using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.CJDCompetitives
{
    public class CJDCompetitiveRepository : BaseRepository<CJDCompetitive>, ICJDCompetitiveRepository
    {
        public CJDCompetitiveRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<CJDCompetitiveDto> GetAll2()
        {
            try
            {
                var results = Context.CJDCompetitives.Select(i => new CJDCompetitiveDto
                {
                    Id = i.Id,
                    MercedesCJDCompetitive = i.MercedesCJDCompetitive,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCJDCompetitive).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CJDCompetitiveDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CJDCompetitiveDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
