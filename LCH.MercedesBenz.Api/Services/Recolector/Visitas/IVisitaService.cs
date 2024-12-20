using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos;

namespace LCH.MercedesBenz.Api.Services.Recolector.Visitas
{
    public interface IVisitaService
    {
        BaseResponse<VisitaDto> GetByCustomQuery(VisitaCustomQueryDto query);
    }
}
