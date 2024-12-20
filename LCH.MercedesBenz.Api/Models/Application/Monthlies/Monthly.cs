using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using LCH.MercedesBenz.Api.Attributes;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Monthlies
{
    [Table("Monthlies")]
    public class Monthly : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileId { get; set; }

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
        public string Mode { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Owner { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string CUIT_PREF { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string COD_PRO { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string DESC_PROV { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string COD_DPT { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string DESC_DPT { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string COD_LOC { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string DESC_LOC { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Zip { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Year_Model { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string CodCar { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string CountryFA { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string CountryPR { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Weight { get; set; } = string.Empty;

        [Required]
        [StringLength(16)]
        public string CUIT { get; set; } = string.Empty;

    }
}
