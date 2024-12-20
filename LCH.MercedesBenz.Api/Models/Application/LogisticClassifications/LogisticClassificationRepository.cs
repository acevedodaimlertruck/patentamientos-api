using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.LogisticClassifications
{
    public class LogisticClassificationRepository : BaseRepository<LogisticClassification>, ILogisticClassificationRepository
    {
        public LogisticClassificationRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<LogisticClassificationDto> GetAll2()
        {
            try
            {
                var results = Context.LogisticClassifications.Select(i => new LogisticClassificationDto
                {
                    Id = i.Id,
                    MercedesLogisticClassification = i.MercedesLogisticClassification,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesLogisticClassification).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<LogisticClassificationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<LogisticClassificationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
