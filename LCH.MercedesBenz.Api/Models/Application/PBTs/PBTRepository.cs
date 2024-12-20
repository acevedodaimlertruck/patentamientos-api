using LCH.MercedesBenz.Api.Models.Application.PBTs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.PBTs
{
    public class PBTRepository : BaseRepository<PBT>, IPBTRepository
    {
        public PBTRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<PBTDto> GetAll2()
        {
            try
            {
                var results = Context.PBTs.Select(i => new PBTDto
                {
                    Id = i.Id,
                    MercedesPBT = i.MercedesPBT,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesPBT).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<PBTDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PBTDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
