using LCH.MercedesBenz.Api.Models.Application.SSegms.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.SSegms
{
    public class SSegmRepository : BaseRepository<SSegm>, ISSegmRepository
    {
        public SSegmRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<SSegmDto> GetAll2()
        {
            try
            {
                var results = Context.SSegms.Select(i => new SSegmDto
                {
                    Id = i.Id,
                    MercedesSSegm = i.MercedesSSegm,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSSegm).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<SSegmDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SSegmDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
