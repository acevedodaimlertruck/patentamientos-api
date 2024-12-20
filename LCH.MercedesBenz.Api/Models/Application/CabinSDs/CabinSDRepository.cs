using LCH.MercedesBenz.Api.Models.Application.CabinSDs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.CabinSDs
{
    public class CabinSDRepository : BaseRepository<CabinSD>, ICabinSDRepository
    {
        public CabinSDRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<CabinSDDto> GetAll2()
        {
            try
            {
                var results = Context.CabinSDs.Select(i => new CabinSDDto
                {
                    Id = i.Id,
                    MercedesCabinSD = i.MercedesCabinSD,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCabinSD).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CabinSDDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CabinSDDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
