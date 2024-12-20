using LCH.MercedesBenz.Api.Models.Application.LegalEntities.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.LegalEntities
{
    public class LegalEntityRepository : BaseRepository<LegalEntity>, ILegalEntityRepository
    {
        public LegalEntityRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<LegalEntityDto> GetAll2()
        {
            try
            {
                var results = Context.LegalEntities.Select(i => new LegalEntityDto
                {
                    Id = i.Id,
                    MercedesLegalEntity = i.MercedesLegalEntity,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.MercedesLegalEntity).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<LegalEntityDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<LegalEntityDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
