using LCH.MercedesBenz.Api.Models.Application.Bodyworks.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Bodyworks
{
    public class BodyworkRepository : BaseRepository<Bodywork>, IBodyworkRepository
    {
        public BodyworkRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<BodyworkDto> GetAll2()
        {
            try
            {
                var results = Context.Bodyworks.Select(i => new BodyworkDto
                {
                    Id = i.Id,
                    MercedesBodywork = i.MercedesBodywork,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesBodywork).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<BodyworkDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<BodyworkDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
