using LCH.MercedesBenz.Api.Models.Application.Powers.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Powers
{
    public class PowerRepository : BaseRepository<Power>, IPowerRepository
    {
        public PowerRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<PowerDto> GetAll2()
        {
            try
            {
                var results = Context.Powers.Select(i => new PowerDto
                {
                    Id = i.Id,
                    MercedesPower = i.MercedesPower,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesPower).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<PowerDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<PowerDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
