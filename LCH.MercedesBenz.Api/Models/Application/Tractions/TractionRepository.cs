using LCH.MercedesBenz.Api.Models.Application.Tractions.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Tractions
{
    public class TractionRepository : BaseRepository<Traction>, ITractionRepository
    {
        public TractionRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<TractionDto> GetAll2()
        {
            try
            {
                var results = Context.Tractions.Select(i => new TractionDto
                {
                    Id = i.Id,
                    MercedesTraction = i.MercedesTraction,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesTraction).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<TractionDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<TractionDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
