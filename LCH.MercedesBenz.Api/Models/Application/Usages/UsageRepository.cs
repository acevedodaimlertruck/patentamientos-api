using LCH.MercedesBenz.Api.Models.Application.Usages.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Usages
{
    public class UsageRepository : BaseRepository<Usage>, IUsageRepository
    {
        public UsageRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<UsageDto> GetAll2()
        {
            try
            {
                var results = Context.Usages.Select(i => new UsageDto
                {
                    Id = i.Id,
                    MercedesUsage = i.MercedesUsage,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesUsage).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<UsageDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<UsageDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
