using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Historicals.Dtos
{
    public class HistoricalSpa : BaseDto
    {
        public int AutoId { get; set; } = 0;
        public Guid FileId { get; set; }
        public File? File { get; set; }
        public string Dominio { get; set; } = string.Empty;
        public string Chasis { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? Dia_Natural { get; set; }
        public string AñoNatural_Mes { get; set; } = string.Empty;
        public string Año_Natural { get; set; } = string.Empty;
        public string OFMM { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? Fecha_de_Inscr { get; set; }
        public string FMM_MTM { get; set; } = string.Empty;
        public string Nro_De_Reg { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
        public string Codigo_Postal { get; set; } = string.Empty;
        public string Año { get; set; } = string.Empty;
        public string Auto { get; set; } = string.Empty;
        public string Pais_Fabricacion { get; set; } = string.Empty;
        public string Pais_Procedencia { get; set; } = string.Empty;
        public string CUIT_Pref { get; set; } = string.Empty;
        public string Cantidad_de_Patentamientos { get; set; } = string.Empty;
        public string Peso { get; set; } = string.Empty;
        public string Origen { get; set; } = string.Empty;
        public string Motor { get; set; } = string.Empty;
        public string Fabrica_Pat { get; set; } = string.Empty;
        public string Marca_Pat { get; set; } = string.Empty;
        public string Modelo_Pat { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? Fecha_de_Carga { get; set; }
        public string OFMM_Error { get; set; } = string.Empty;
        public string Es_Pat_Duplicado { get; set; } = string.Empty;
        public string CUIT_Titular { get; set; } = string.Empty;
    }
}
