namespace LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos
{
    public class VisitaFilterDto
    {
        /// <summary>
        /// Código de usuario
        /// </summary>
        public string CodUsuario { get; set; }

        /// <summary>
        /// Código de versión
        /// </summary>
        public string CodVersion { get; set; }

        public string By { get; set; }

        public string Value { get; set; }
    }
}