using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Dailies.Dtos
{
    public class DailyDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public File? File { get; set; }

        [Required]
        [StringLength(128)]
        public string Source { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Plate { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Motor { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Chassis { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string FMM_MTM { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Factory_D { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Brand_D { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Model_D { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Type_D { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? Reg_Date { get; set; }

        [Required]
        [StringLength(128)]
        public string RegSec { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Desc_Reg { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Desc_Prov { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Taxi { get; set; } = string.Empty;

        [Required]
        [StringLength(16)]
        public string CUIT { get; set; } = string.Empty;
    }
}
