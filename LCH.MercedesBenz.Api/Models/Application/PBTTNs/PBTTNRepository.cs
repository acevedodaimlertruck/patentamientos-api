using LCH.MercedesBenz.Api.Models.Application.PBTTNs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.PBTTNs
{
    public class PBTTNRepository : BaseRepository<PBTTN>, IPBTTNRepository
    {
        public PBTTNRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<PBTTNDto> GetAll2()
        {
            try
            {
                var results = Context.PBTTNs.Select(i => new PBTTNDto
                {
                    Id = i.Id,
                    MercedesPBTTN = i.MercedesPBTTN,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesPBTTN).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<PBTTNDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PBTTNDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
