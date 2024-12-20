using LCH.MercedesBenz.Api.Models.Application.AperturesTwo.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.AperturesTwo
{
    public class ApertureTwoRepository : BaseRepository<ApertureTwo>, IApertureTwoRepository
    {
        public ApertureTwoRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<ApertureTwoDto> GetAll2()
        {
            try
            {
                var results = Context.AperturesTwo.Select(i => new ApertureTwoDto
                {
                    Id = i.Id,
                    MercedesApertureTwo = i.MercedesApertureTwo,
                    SegCategory = i.SegCategory,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesApertureTwo).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<ApertureTwoDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<ApertureTwoDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
