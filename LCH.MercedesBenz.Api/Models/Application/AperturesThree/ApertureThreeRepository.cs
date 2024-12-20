using LCH.MercedesBenz.Api.Models.Application.ApertureThrees.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureThrees
{
    public class ApertureThreeRepository : BaseRepository<ApertureThree>, IApertureThreeRepository
    {
        public ApertureThreeRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<ApertureThreeDto> GetAll2()
        {
            try
            {
                var results = Context.AperturesThree.Select(i => new ApertureThreeDto
                {
                    Id = i.Id,
                    MercedesApertureThree = i.MercedesApertureThree,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesApertureThree).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<ApertureThreeDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ApertureThreeDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
