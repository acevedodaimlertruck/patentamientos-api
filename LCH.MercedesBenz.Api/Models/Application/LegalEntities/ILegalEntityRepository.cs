using LCH.MercedesBenz.Api.Models.Application.LegalEntities.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.LegalEntities
{
    public interface ILegalEntityRepository : IBaseRepository<LegalEntity>
    {
        BaseResponse<LegalEntityDto> GetAll2();
    }
}
