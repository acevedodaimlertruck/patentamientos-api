using LCH.MercedesBenz.Api.Models.Application.WheelBases.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.WheelBases
{
    public class WheelBaseRepository : BaseRepository<WheelBase>, IWheelBaseRepository
    {
        public WheelBaseRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<WheelBaseDto> GetAll2()
        {
            try
            {
                var results = Context.WheelBases.Select(i => new WheelBaseDto
                {
                    Id = i.Id,
                    MercedesWheelBase = i.MercedesWheelBase,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesWheelBase).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<WheelBaseDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<WheelBaseDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
