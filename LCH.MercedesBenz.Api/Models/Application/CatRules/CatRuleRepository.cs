using LCH.MercedesBenz.Api.Models.Application.CatRules.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.CatRules
{
    public class CatRuleRepository : BaseRepository<CatRule>, ICatRuleRepository
    {
        public CatRuleRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<CatRuleDto> GetAll2()
        {
            try
            {
                var results = Context.CatRules.Select(i => new CatRuleDto
                {
                    Id = i.Id,
                    MercedesCatRule = i.MercedesCatRule,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCatRule).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<CatRuleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<CatRuleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
