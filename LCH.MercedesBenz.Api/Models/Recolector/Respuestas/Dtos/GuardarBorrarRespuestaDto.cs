namespace LCH.MercedesBenz.Api.Models.Recolector.Respuestas.Dtos
{
    public class GuardarBorrarRespuestaDto
    {
        public string? CodVersion { get; set; }
        public string? Respuestas { get; set; }
        public string? CodUsuario { get; set; }
        public string? CodVisita { get; set; }
        public string? CodTipoDato { get; set; }
        public string? Accion { get; set; }
        public string? ValorViejo { get; set; }
        public string? CodOpcionViejo { get; set; }
        public string? CodSeccionModulo { get; set; }
        public string? CodEntidad { get; set; }
        public string? Agrupamiento { get; set; }
        public string? CodPreguntaSeccion { get; set; }
        public string? CodOpcionOmitir { get; set; }
        public string? CodBloque { get; set; }
    }
}