using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s
{
    public class SegmentationAux1Repository : BaseRepository<SegmentationAux1>, ISegmentationAux1Repository
    {
        public SegmentationAux1Repository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<SegmentationAux1Dto> GetAll2()
        {
            try
            {
                var results = Context.SegmentationAux1s.Select(i => new SegmentationAux1Dto
                {
                    Id = i.Id,
                    MercedesSegmentationAux1 = i.MercedesSegmentationAux1,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSegmentationAux1).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<SegmentationAux1Dto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SegmentationAux1Dto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
