using LCH.MercedesBenz.Api.Models.Application.AltSegms.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.AltSegms
{
    public class AltSegmRepository : BaseRepository<AltSegm>, IAltSegmRepository
    {
        public AltSegmRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<AltSegmDto> GetAll2()
        {
            try
            {
                var results = Context.AltSegms.Select(i => new AltSegmDto
                {
                    Id = i.Id,
                    MercedesAltSegm = i.MercedesAltSegm,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAltSegm).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<AltSegmDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<AltSegmDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
