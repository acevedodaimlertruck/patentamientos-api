using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Dailies.Dtos
{
    public class DailySpa : BaseDto
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
        [StringLength(128)]
        public string Titular { get; set; } = string.Empty;

        [Required]
        [StringLength(16)]
        public string Cuit_Titular { get; set; } = string.Empty;
    }
}
