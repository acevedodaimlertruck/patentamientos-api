using LCH.MercedesBenz.Api.Models.Application.AxleBases.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.AxleBases
{
    public class AxleBaseRepository : BaseRepository<AxleBase>, IAxleBaseRepository
    {
        public AxleBaseRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<AxleBaseDto> GetAll2()
        {
            try
            {
                var results = Context.AxleBases.Select(i => new AxleBaseDto
                {
                    Id = i.Id,
                    MercedesAxleBase = i.MercedesAxleBase,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAxleBase).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<AxleBaseDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<AxleBaseDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
