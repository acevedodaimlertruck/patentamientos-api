namespace LCH.MercedesBenz.Api.Models.Recolector.Entidades.Dtos
{
    public class EntidadDto
    {
        public string? CodEntidad { get; set; }

        public string? CodObjeto { get; set; }

        public string? NombreCompleto { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string? CodSexo { get; set; }

        public string? CodTipoEstadoCivil { get; set; }

        public DateTime? FechaRegistroRespuesta { get; set; }

        public DateTime? FechaInicialVisita { get; set; }

        public string? CodHogar { get; set; }

        public string? Hogar { get; set; }

        public bool? JefeDeHogar { get; set; }
    }
}