using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationPlates.Dtos
{
    public class SegmentationPlateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        public Guid? PatentingId { get; set; }

        public PatentingDto? Patenting { get; set; }

        public Guid? OfmmId { get; set; }

        public OfmmDto? Ofmm { get; set; }

        public Guid? KeyVersionId { get; set; }

        public KeyVersionDto? KeyVersion { get; set; }

        public string? MercedesSegmentacionDominioId { get; set; }

        public int? MercedesSegmentacionDominioNumero { get; set; }

        public Guid? FileId { get; set; }

        public FileDto? File { get; set; }
    }
}
