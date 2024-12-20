using LCH.MercedesBenz.Api.Models.Application.CuitClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CuitClassifications
{
    public class CuitClassificationRepository : BaseRepository<CuitClassification>, ICuitClassificationRepository
    {
        public CuitClassificationRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<CuitClassificationDto> GetAll2()
        {
            try
            {
                var results = Context.CuitClassifications.Select(i => new CuitClassificationDto
                {
                    Id = i.Id,
                    MercedesCuitClassification = i.MercedesCuitClassification,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesCuitClassification).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CuitClassificationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CuitClassificationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
