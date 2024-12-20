using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Monthlies.Dtos
{
    public class MonthlySpa : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public File? File { get; set; }

        [Required]
        [StringLength(128)]
        public string Origen { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Dominio { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Motor { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Chasis { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string FMM_MTM { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Fabrica_Desc { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Marca_Desc { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Modelo_Desc { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Tipo_Desc { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? Fecha_De_Inscr { get; set; }

        [Required]
        [StringLength(128)]
        public string Nro_De_Reg { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Registro_Desc { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Modo { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Titular { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Prefijo_Cuit { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Provincia { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Provincia_Desc { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Departamento { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Despartamento_Desc { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Localidad { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Localidad_Desc { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Ciudad { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Codigo_Postal { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Año_Modelo { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Auto { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Pais_Fabricacion { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Pais_Procedencia { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Peso { get; set; } = string.Empty;

        [Required]
        [StringLength(16)]
        public string Cuit_Titular { get; set; } = string.Empty;
    }
}