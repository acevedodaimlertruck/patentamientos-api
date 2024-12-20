using LCH.MercedesBenz.Api.Models.Application.ApertureFours.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureFours
{
    public class ApertureFourRepository : BaseRepository<ApertureFour>, IApertureFourRepository
    {
        public ApertureFourRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<ApertureFourDto> GetAll2()
        {
            try
            {
                var results = Context.AperturesFour.Select(i => new ApertureFourDto
                {
                    Id = i.Id,
                    MercedesApertureFour = i.MercedesApertureFour,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesApertureFour).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<ApertureFourDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ApertureFourDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
