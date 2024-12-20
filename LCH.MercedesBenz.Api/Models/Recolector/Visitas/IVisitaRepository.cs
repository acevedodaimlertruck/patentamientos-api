using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Visitas
{
    public interface IVisitaRepository : IBaseRecolectorRepository<VisitaEntity>
    {
        BaseResponse<VisitaDto> GetByCustomQuery(VisitaCustomQueryDto query);
    }
}
