using LCH.MercedesBenz.Api.Models.Application;

namespace LCH.MercedesBenz.Api.Models.Universal.Individuos
{
    public interface IIndividuoRepository : IBaseUniversalRepository<IndividuoEntity>
    {
        BaseResponse<IndividuoEntity> GetByCodPersonas(List<string> codPersonas);
    }
}
