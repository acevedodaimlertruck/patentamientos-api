using LCH.MercedesBenz.Api.Models.Application.AltBodysts.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.AltBodysts
{
    public class AltBodystRepository : BaseRepository<AltBodyst>, IAltBodystRepository
    {
        public AltBodystRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<AltBodystDto> GetAll2()
        {
            try
            {
                var results = Context.AltBodysts.Select(i => new AltBodystDto
                {
                    Id = i.Id,
                    MercedesAltBodyst = i.MercedesAltBodyst,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAltBodyst).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<AltBodystDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<AltBodystDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
