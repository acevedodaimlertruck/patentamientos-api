using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Universal.Individuos
{
    public class IndividuoRepository : BaseUniversalRepository<IndividuoEntity>, IIndividuoRepository
    {
        public IndividuoRepository(UniversalDbContext context) : base(context)
        {
        }

        public BaseResponse<IndividuoEntity> GetByCodPersonas(List<string> codPersonas)
        {
            try
            {
                var results = Context.Individuos
                    .Where(i => codPersonas.Contains(i.CodPersona))
                    .ToList();
                return new BaseResponse<IndividuoEntity>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<IndividuoEntity>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Context.Dispose();
            }
        }
    }
}
