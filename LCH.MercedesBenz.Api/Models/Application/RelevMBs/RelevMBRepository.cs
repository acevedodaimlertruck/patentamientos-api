using LCH.MercedesBenz.Api.Models.Application.RelevMBs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.RelevMBs
{
    public class RelevMBRepository : BaseRepository<RelevMB>, IRelevMBRepository
    {
        public RelevMBRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<RelevMBDto> GetAll2()
        {
            try
            {
                var results = Context.RelevMBs.Select(i => new RelevMBDto
                {
                    Id = i.Id,
                    MercedesRelevMB = i.MercedesRelevMB,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesRelevMB).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<RelevMBDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<RelevMBDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
