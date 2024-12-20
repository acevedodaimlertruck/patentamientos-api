using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.AperturesOne;
using LCH.MercedesBenz.Api.Models.Application.AperturesTwo;
using LCH.MercedesBenz.Api.Models.Application.CuitClassifications;
using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers;
using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications;
using LCH.MercedesBenz.Api.Models.Application.LegalEntities;
using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications;
using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications;
using Newtonsoft.Json;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications
{
    [Table("OdsOwnerClassifications")]
    public class OdsOwnerClassification : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(20)]
        public string CuitOwner { get; set; } = string.Empty;

        [StringLength(120)]
        public string Owner { get; set; } = string.Empty;

        [StringLength(3)]
        public string MercedesLegalEntity { get; set; } = string.Empty;

        [Required]
        public Guid LegalEntityId { get; set; }

        [JsonIgnore]
        public virtual LegalEntity? LegalEntity { get; set; }

        [StringLength(2)]
        public string MercedesGovernmentalClassification { get; set; } = string.Empty;

        [Required]
        public Guid GovernmentalClassificationId { get; set; }

        [JsonIgnore]
        public virtual GovernmentalClassification? GovernmentalClassification { get; set; }

        [StringLength(3)]
        public string MercedesSubgovernmentalClassification { get; set; } = string.Empty;

        [Required]
        public Guid SubgovernmentalClassificationId { get; set; }

        [JsonIgnore]
        public virtual SubgovernmentalClassification? SubgovernmentalClassification { get; set; }

        [StringLength(2)]
        public string MercedesCuitClassification { get; set; } = string.Empty;

        [Required]
        public Guid CuitClassificationId { get; set; }

        [JsonIgnore]
        public virtual CuitClassification? CuitClassification { get; set; }

        [StringLength(3)]
        public string Aperture1 { get; set; } = string.Empty;

        [Required]
        public Guid ApertureOneId { get; set; }

        [JsonIgnore]
        public virtual ApertureOne? ApertureOne { get; set; }

        [StringLength(3)]
        public string Aperture2 { get; set; } = string.Empty;

        [Required]
        public Guid ApertureTwoId { get; set; }

        [JsonIgnore]
        public virtual ApertureTwo? ApertureTwo { get; set; }

        [StringLength(3)]
        public string MercedesLogisticClassification { get; set; } = string.Empty;

        [Required]
        public Guid LogisticClassificationId { get; set; }

        [JsonIgnore]
        public virtual LogisticClassification? LogisticClassification { get; set; }

        [StringLength(3)]
        public string MercedesEstimatedTurnover { get; set; } = string.Empty;

        [Required]
        public Guid EstimatedTurnoverId { get; set; }

        [JsonIgnore]
        public virtual EstimatedTurnover? EstimatedTurnover { get; set; }

        [StringLength(10)]
        public string SocialContractDate { get; set; } = string.Empty;

        [StringLength(30)]
        public string EmployeesInfo { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public File? File { get; set; }
    }
}
