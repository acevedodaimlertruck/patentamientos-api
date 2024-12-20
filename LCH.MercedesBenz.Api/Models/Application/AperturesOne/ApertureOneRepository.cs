using LCH.MercedesBenz.Api.Models.Application.AperturesOne.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesOne
{
    public class ApertureOneRepository : BaseRepository<ApertureOne>, IApertureOneRepository
    {
        public ApertureOneRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<ApertureOneDto> GetAll2()
        {
            try
            {
                var results = Context.AperturesOne.Select(i => new ApertureOneDto
                {
                    Id = i.Id,
                    MercedesApertureOne = i.MercedesApertureOne,
                    SegCategory = i.SegCategory,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesApertureOne).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<ApertureOneDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ApertureOneDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
