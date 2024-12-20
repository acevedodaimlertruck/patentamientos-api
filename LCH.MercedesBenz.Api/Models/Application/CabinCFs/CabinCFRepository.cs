using LCH.MercedesBenz.Api.Models.Application.CabinCFs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.CabinCFs
{
    public class CabinCFRepository : BaseRepository<CabinCF>, ICabinCFRepository
    {
        public CabinCFRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<CabinCFDto> GetAll2()
        {
            try
            {
                var results = Context.CabinCFs.Select(i => new CabinCFDto
                {
                    Id = i.Id,
                    MercedesCabinCF = i.MercedesCabinCF,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCabinCF).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CabinCFDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CabinCFDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
