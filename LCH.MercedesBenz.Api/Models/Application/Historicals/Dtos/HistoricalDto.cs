using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.Files;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Historicals.Dtos
{
    public class HistoricalDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [StringLength(128)]
        public string Plate { get; set; } = string.Empty;

        [StringLength(128)]
        public string Chassis { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? NaturalDay { get; set; }

        [StringLength(32)]
        public string YearMonth { get; set; } = string.Empty;

        [StringLength(32)]
        public string NaturalYear { get; set; } = string.Empty;

        [StringLength(60)]
        public string OFMM { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? RegDate { get; set; }

        [StringLength(60)]
        public string FMM_MTM { get; set; } = string.Empty;

        [StringLength(60)]
        public string RegNum { get; set; } = string.Empty;

        [StringLength(128)]
        public string Owner { get; set; } = string.Empty;

        [StringLength(128)]
        public string Address { get; set; } = string.Empty;

        [StringLength(60)]
        public string Province { get; set; } = string.Empty;

        [StringLength(60)]
        public string Department { get; set; } = string.Empty;

        [StringLength(60)]
        public string Location { get; set; } = string.Empty;

        [StringLength(60)]
        public string PostalCode { get; set; } = string.Empty;

        [StringLength(60)]
        public string Year { get; set; } = string.Empty;

        [StringLength(128)]
        public string Car { get; set; } = string.Empty;

        [StringLength(128)]
        public string ManufactureCountry { get; set; } = string.Empty;

        [StringLength(128)]
        public string OriginCountry { get; set; } = string.Empty;

        [StringLength(60)]
        public string CUITPref { get; set; } = string.Empty;

        [StringLength(60)]
        public string PatQuantity { get; set; } = string.Empty;

        [StringLength(60)]
        public string Weight { get; set; } = string.Empty;

        [StringLength(60)]
        public string Origin { get; set; } = string.Empty;

        [StringLength(128)]
        public string Motor { get; set; } = string.Empty;

        [StringLength(128)]
        public string FactoryPat { get; set; } = string.Empty;

        [StringLength(128)]
        public string BrandPat { get; set; } = string.Empty;

        [StringLength(128)]
        public string CarModelPat { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? UploadDate { get; set; }

        [StringLength(128)]
        public string OFMMError { get; set; } = string.Empty;

        [StringLength(128)]
        public string IsPatDuplicated { get; set; } = string.Empty;

        [StringLength(128)]
        public string CUITOwner { get; set; } = string.Empty;

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public File? File { get; set; }
    }
}
