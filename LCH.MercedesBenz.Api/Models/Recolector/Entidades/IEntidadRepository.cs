using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Entidades.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Entidades
{
    public interface IEntidadRepository
    {
        BaseResponse<EntidadDto> GetEntidades(string codVersion, string codVisita, bool incluirPersonas = true, bool incluirViviendas = true, bool dispose = true);

        BaseResponse<Dictionary<string, ICollection<EntidadDto>>> GetEntidadesPorSeccion(string codVersion, string codVisita);
    }
}
