using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Entidades.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Personas
{
    public interface IPersonaRepository : IBaseRecolectorRepository<PersonaEntity>
    {
        BaseResponse<EntidadDto> GetPersonas(string codVersion, string codVisita);
    }
}
