using LCH.MercedesBenz.Api.Models.Application.Sources.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.Sources
{
    public class SourceRepository : BaseRepository<Source>, ISourceRepository
    {
        public SourceRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<SourceDto> GetAll2()
        {
            try
            {
                var results = Context.Sources.Select(i => new SourceDto
                {
                    Id = i.Id,
                    MercedesSource = i.MercedesSource,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSource).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<SourceDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SourceDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
