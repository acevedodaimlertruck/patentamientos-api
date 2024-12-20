using LCH.MercedesBenz.Api.Models.Application.AltCategs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.AltCategs
{
    public class AltCategRepository : BaseRepository<AltCateg>, IAltCategRepository
    {
        public AltCategRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<AltCategDto> GetAll2()
        {
            try
            {
                var results = Context.AltCategs.Select(i => new AltCategDto
                {
                    Id = i.Id,
                    MercedesAltCateg = i.MercedesAltCateg,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAltCateg).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<AltCategDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<AltCategDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
