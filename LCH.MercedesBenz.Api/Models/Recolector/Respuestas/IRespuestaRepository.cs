using LCH.MercedesBenz.Api.Models.Application;
using LCH.MercedesBenz.Api.Models.Recolector.Respuestas.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Respuestas
{
    public interface IRespuestaRepository : IBaseRecolectorRepository<RespuestaEntity>
    {
        BaseResponse<RespuestaDto> GetRespuestas(string codVersion, string codVisita);

        BaseResponse<Dictionary<string, Dictionary<string, ICollection<RespuestaDto>>>> GetRespuestasPorSeccionEntidad(string codVersion, string codVisita);

        BaseResponse<dynamic> Guardar(
            string respuestas,
            string codVersion,
            string codVisita,
            string codUsuario,
            string codTipoDato,
            string accion,
            string valorViejo,
            string codOpcionViejo,
            string codBloque);

        BaseResponse<dynamic> BorrarBySeccion(
            string codSeccionModulo,
            string codVersion,
            string codVisita,
            string codUsuario,
            string codEntidad);

        BaseResponse<dynamic> BorrarByAgrupamiento(
            string codVersion,
            string codVisita,
            string agrupamiento,
            string codBloque);

        BaseResponse<dynamic> BorrarByAgrupamientos(
            string codSeccionModulo,
            string codVisita,
            string agrupamiento);

        BaseResponse<dynamic> BorrarMasivo(
            string codVersion,
            string codVisita,
            string codPreguntaSeccion,
            string codEntidad,
            string codOpcionOmitir,
            string agrupamiento);
    }
}
