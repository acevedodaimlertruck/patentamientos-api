using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.PreguntasSeccion.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.PreguntaSecciones
{
    public interface IPreguntaSeccionRepository : IBaseRecolectorRepository<PreguntaSeccionEntity>
    {
        BaseResponse<Dictionary<string, ICollection<PreguntaSeccionDto>>> GetPreguntasPorSeccion(string codVersion, string codVisita);
    }
}
