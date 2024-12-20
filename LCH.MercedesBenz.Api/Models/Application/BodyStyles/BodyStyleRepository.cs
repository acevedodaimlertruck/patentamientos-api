using LCH.MercedesBenz.Api.Models.Application.BodyStyles.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.BodyStyles
{
    public class BodyStyleRepository : BaseRepository<BodyStyle>, IBodyStyleRepository
    {
        public BodyStyleRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<BodyStyleDto> GetAll2()
        {
            try
            {
                var results = Context.BodyStyles.Select(i => new BodyStyleDto
                {
                    Id = i.Id,
                    MercedesBodyStyle = i.MercedesBodyStyle,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesBodyStyle).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<BodyStyleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<BodyStyleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
