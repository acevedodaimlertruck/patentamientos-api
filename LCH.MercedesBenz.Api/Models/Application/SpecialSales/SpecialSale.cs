using LCH.MercedesBenz.Api.Models.Application.Files;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.SpecialSales
{
    [Table("SpecialSales")]
    public class SpecialSale : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(20)]
        public string CuitOwner { get; set; } = string.Empty;

        [StringLength(120)]
        public string Owner { get; set; } = string.Empty;

        [StringLength(3)]
        public string LegalEntity { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionLegalEntity { get; set; } = string.Empty;

        [StringLength(2)]
        public string GovernmentalClassification { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionGovernmentalClassification { get; set; } = string.Empty;

        [StringLength(3)]
        public string SubgovernmentalClassification { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionSubgovernmentalClassification { get; set; } = string.Empty;

        [StringLength(2)]
        public string CuitClassification { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionCuitClassification { get; set; } = string.Empty;

        [StringLength(3)]
        public string Aperture1 { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionAperture1 { get; set; } = string.Empty;

        [StringLength(3)]
        public string Aperture2 { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionAperture2 { get; set; } = string.Empty;

        [StringLength(3)]
        public string LogisticClassification { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionLogisticClassification { get; set; } = string.Empty;

        [StringLength(3)]
        public string EstimatedTurnover { get; set; } = string.Empty;

        [StringLength(60)]
        public string DescriptionEstimatedTurnover { get; set; } = string.Empty;

        [StringLength(10)]
        public string SocialContractDate { get; set; } = string.Empty;

        [StringLength(30)]
        public string EmployeesInfo { get; set; } = string.Empty;

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public File? File { get; set; }

    }
}
