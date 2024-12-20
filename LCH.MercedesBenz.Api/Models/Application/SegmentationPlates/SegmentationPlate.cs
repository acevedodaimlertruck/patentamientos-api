using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions;
using LCH.MercedesBenz.Api.Models.Application.OFMM;
using LCH.MercedesBenz.Api.Models.Application.Patentings;
using Newtonsoft.Json;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationPlates
{
    [Table("SegmentationPlates")]
    public class SegmentationPlate : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        public Guid? PatentingId { get; set; }

        [JsonIgnore]
        public Patenting? Patenting { get; set; }

        public Guid? OfmmId { get; set; }

        [JsonIgnore]
        public Ofmm? Ofmm { get; set; }

        public Guid? KeyVersionId { get; set; }

        [JsonIgnore]
        public KeyVersion? KeyVersion { get; set; }

        [StringLength(512)]
        public string? MercedesSegmentacionDominioId { get; set; }

        public int? MercedesSegmentacionDominioNumero { get; set; }

        public Guid? FileId { get; set; }

        [JsonIgnore]
        public File? File { get; set; }
    }
}
