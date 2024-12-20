using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.Dailies;
using LCH.MercedesBenz.Api.Models.Application.EventFiles;
using LCH.MercedesBenz.Api.Models.Application.FileTypes;
using LCH.MercedesBenz.Api.Models.Application.Historicals;
using LCH.MercedesBenz.Api.Models.Application.Monthlies;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates;
using LCH.MercedesBenz.Api.Models.Application.Wholesales;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Files
{
    [Table("Files")]
    public class File : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Status { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string RecordQuantity { get; set; } = string.Empty;

        [Required]
        public string URL { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Date { get; set; } = string.Empty;

        [Required]
        [StringLength(8)]
        public string Day { get; set; } = string.Empty;

        [Required]
        [StringLength(24)]
        public string Month { get; set; } = string.Empty;

        [Required]
        [StringLength(8)]
        public string Year { get; set; } = string.Empty;
        [Required]
        public Guid FileTypeID { get; set; }

        public FileType? FileType { get; set; }

        public string? FileUpload { get; set; }

        [JsonIgnore]
        public virtual ICollection<EventFile> EventFiles { get; set; } = new HashSet<EventFile>();

        [JsonIgnore]
        public virtual ICollection<Daily> Dailies { get; set; } = new HashSet<Daily>();

        [JsonIgnore]
        public virtual ICollection<Wholesale> Wholesales { get; set; } = new HashSet<Wholesale>();

        [JsonIgnore]
        public virtual ICollection<Monthly> Monthlies { get; set; } = new HashSet<Monthly>();

        [JsonIgnore]
        public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();

        [JsonIgnore]
        public virtual ICollection<OdsWholesale> OdsWholesales { get; set; } = new HashSet<OdsWholesale>();

        [JsonIgnore]
        public virtual ICollection<SegmentationPlate> SegmentationPlates { get; set; } = new HashSet<SegmentationPlate>();

        [JsonIgnore]
        public virtual ICollection<Historical> Historicals { get; set; } = new HashSet<Historical>();
    }
}
