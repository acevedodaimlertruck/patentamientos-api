using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers
{
    public class EstimatedTurnoverRepository : BaseRepository<EstimatedTurnover>, IEstimatedTurnoverRepository
    {
        public EstimatedTurnoverRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<EstimatedTurnoverDto> GetAll2()
        {
            try
            {
                var results = Context.EstimatedTurnovers.Select(i => new EstimatedTurnoverDto
                {
                    Id = i.Id,
                    MercedesEstimatedTurnover = i.MercedesEstimatedTurnover,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesEstimatedTurnover).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<EstimatedTurnoverDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<EstimatedTurnoverDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
