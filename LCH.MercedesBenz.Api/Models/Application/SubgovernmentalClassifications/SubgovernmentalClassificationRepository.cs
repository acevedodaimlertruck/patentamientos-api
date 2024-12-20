using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications
{
    public class SubgovernmentalClassificationRepository : BaseRepository<SubgovernmentalClassification>, ISubgovernmentalClassificationRepository
    {
        public SubgovernmentalClassificationRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<SubgovernmentalClassificationDto> GetAll2()
        {
            try
            {
                var results = Context.SubgovernmentalClassifications.Select(i => new SubgovernmentalClassificationDto
                {
                    Id = i.Id,
                    MercedesSubgovernmentalClassification = i.MercedesSubgovernmentalClassification,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesSubgovernmentalClassification).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<SubgovernmentalClassificationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SubgovernmentalClassificationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
