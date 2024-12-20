using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications
{
    public class GovernmentalClassificationRepository : BaseRepository<GovernmentalClassification>, IGovernmentalClassificationRepository
    {
        public GovernmentalClassificationRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<GovernmentalClassificationDto> GetAll2()
        {
            try
            {
                var results = Context.GovernmentalClassifications.Select(i => new GovernmentalClassificationDto
                {
                    Id = i.Id,
                    MercedesGovernmentalClassification = i.MercedesGovernmentalClassification,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesGovernmentalClassification).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<GovernmentalClassificationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<GovernmentalClassificationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
