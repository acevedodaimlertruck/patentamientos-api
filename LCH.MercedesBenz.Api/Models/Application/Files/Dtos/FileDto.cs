using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Files.Dtos
{
    public class FileDto : BaseDto
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

        public FileTypeDto? FileType { get; set; }

        public string? FileUpload { get; set; }

    }
}
