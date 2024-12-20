using LCH.MercedesBenz.Api.Models.Application.Subsegments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Subsegments
{
    public class SubsegmentRepository : BaseRepository<Subsegment>, ISubsegmentRepository
    {
        public SubsegmentRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<SubsegmentDto> GetAll2()
        {
            try
            {
                var results = Context.Subsegments.Select(i => new SubsegmentDto
                {
                    Id = i.Id,
                    MercedesSubsegment = i.MercedesSubsegment,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSubsegment).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<SubsegmentDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SubsegmentDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
