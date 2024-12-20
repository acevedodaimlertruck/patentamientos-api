using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts
{
    public class MCGTotalMktRepository : BaseRepository<MCGTotalMkt>, IMCGTotalMktRepository
    {
        public MCGTotalMktRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<MCGTotalMktDto> GetAll2()
        {
            try
            {
                var results = Context.MCGTotalMkts.Select(i => new MCGTotalMktDto
                {
                    Id = i.Id,
                    MercedesMCGTotalMkt = i.MercedesMCGTotalMkt,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesMCGTotalMkt).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<MCGTotalMktDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<MCGTotalMktDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
