using LCH.MercedesBenz.Api.Models.Application.AperturesOne.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AperturesTwo.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CuitClassifications.Dtos;
using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using LCH.MercedesBenz.Api.Models.Application.GovernmentalClassifications.Dtos;
using LCH.MercedesBenz.Api.Models.Application.LegalEntities.Dtos;
using LCH.MercedesBenz.Api.Models.Application.LogisticClassifications.Dtos;
using LCH.MercedesBenz.Api.Models.Application.SubgovernmentalClassifications.Dtos;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.OdsOwnerClassifications.Dtos
{
    public class OdsOwnerClassificationDto : BaseDto
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
        public LegalEntityDto? LegalEntity { get; set; }

        [StringLength(2)]
        public string MercedesGovernmentalClassification { get; set; } = string.Empty;

        [Required]
        public Guid GovernmentalClassificationId { get; set; }

        [JsonIgnore]
        public GovernmentalClassificationDto? GovernmentalClassification { get; set; }

        [StringLength(3)]
        public string MercedesSubgovernmentalClassification { get; set; } = string.Empty;

        [Required]
        public Guid SubgovernmentalClassificationId { get; set; }

        [JsonIgnore]
        public SubgovernmentalClassificationDto? SubgovernmentalClassification { get; set; }

        [StringLength(2)]
        public string MercedesCuitClassification { get; set; } = string.Empty;

        [Required]
        public Guid CuitClassificationId { get; set; }

        [JsonIgnore]
        public CuitClassificationDto? CuitClassification { get; set; }

        [StringLength(3)]
        public string Aperture1 { get; set; } = string.Empty;

        [Required]
        public Guid ApertureOneId { get; set; }

        [JsonIgnore]
        public ApertureOneDto? ApertureOne { get; set; }

        [StringLength(3)]
        public string Aperture2 { get; set; } = string.Empty;

        [Required]
        public Guid ApertureTwoId { get; set; }

        [JsonIgnore]
        public ApertureTwoDto? ApertureTwo { get; set; }

        [StringLength(3)]
        public string MercedesLogisticClassification { get; set; } = string.Empty;

        [Required]
        public Guid LogisticClassificationId { get; set; }

        [JsonIgnore]
        public LogisticClassificationDto? LogisticClassification { get; set; }

        [StringLength(3)]
        public string MercedesEstimatedTurnover { get; set; } = string.Empty;

        [Required]
        public Guid EstimatedTurnoverId { get; set; }

        [JsonIgnore]
        public EstimatedTurnoverDto? EstimatedTurnover { get; set; }

        [StringLength(10)]
        public string SocialContractDate { get; set; } = string.Empty;

        [StringLength(30)]
        public string EmployeesInfo { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public FileDto? File { get; set; }
    }
}
