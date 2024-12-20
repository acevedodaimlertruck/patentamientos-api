using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations.Dtos
{
    public class InternalVersionSegmentationCreateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid Cat_InternalVersionId { get; set; }

        public string? MercedesVersionInternaId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public string? MercedesCategoriaId { get; set; }

        [Required]
        public Guid SegmentId { get; set; }

        public string? MercedesSegmentoId { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DischargeDate { get; set; } // Fecha de Alta

        public string? Description { get; set; }

        public string? AltBodyst { get; set; }
        public Guid? AltBodystId { get; set; }

        public string? AltCateg { get; set; }
        public Guid? AltCategId { get; set; }

        public string? AltSegm { get; set; }
        public Guid? AltSegmId { get; set; }

        public string? AMGCompSet { get; set; }
        public Guid? AMGCompSetId { get; set; }

        public string? Apertura1 { get; set; }
        public Guid? Apertura1Id { get; set; }

        public string? Apertura2 { get; set; }
        public Guid? Apertura2Id { get; set; }

        public string? Apertura3 { get; set; }
        public Guid? Apertura3Id { get; set; }

        public string? Apertura4 { get; set; }
        public Guid? Apertura4Id { get; set; }

        public string? MercedesBodyStyle { get; set; }
        public Guid BodyStyleId { get; set; }
        public string? CabinaCF { get; set; }
        public Guid? CabinaCFId { get; set; }

        public string? CabinaSD { get; set; }
        public Guid? CabinaSDId { get; set; }

        public string? EngineCapacity { get; set; } // Cilindrada(Cm3)
        public Guid? EngineCapacityId { get; set; }

        public string? CJDCompetitive { get; set; }
        public Guid? CJDCompetitiveId { get; set; }

        public string? Fuel { get; set; } // Combustible
        public Guid? FuelTypeId { get; set; }

        public string? CompetitiveCJD { get; set; }
        public Guid? CompetitiveCJDId { get; set; }

        public string? MercedesConfiguration { get; set; }
        public Guid? MercedesConfigurationId { get; set; }

        public Guid BodyworkId { get; set; }


        public string? Wheelbase { get; set; }  // Distancia entre Ejes
        public Guid? WheelBaseId { get; set; }

        public string? AxleBase { get; set; } // Dist.Entre Ejes
        public Guid? AxleBaseId { get; set; }

        public string? Group { get; set; } // Group(6)
        public Guid? GroupId { get; set; }

        public string? Gears { get; set; } // Marchas
        public Guid? GearsId { get; set; }

        public string? MCGTotalMkt { get; set; }
        public Guid? MCGTotalMktId { get; set; }

        public string? MotorDT { get; set; }
        public Guid? MotorDTId { get; set; }

        public string? NI { get; set; }
        public Guid? NIId { get; set; }

        public string? Rule { get; set; }
        public Guid? RuleId { get; set; }

        public string? Source { get; set; }
        public Guid? SourceId { get; set; }

        public string? MercedesPBT { get; set; }
        public Guid? MercedesPBTId { get; set; }

        public Guid SubsegmentId { get; set; }

        public string? PBT_TN { get; set; }
        public Guid? PBT_TNId { get; set; }

        public string? MercedesPower { get; set; }     
        public Guid PowerId { get; set; }

        public string? Doors { get; set; }
        public Guid DoorsId { get; set; }

        public string? RelevMB { get; set; }
        public Guid RelevMBId { get; set; }

        public string? SSegm { get; set; }
        public Guid SSegmId { get; set; }

        public Guid CatRuleId {  get; set; }

        public string? MercedesTraction { get; set; }
        public Guid TractionId { get; set; }

        public string? MercedesUsage { get; set; }
        public Guid UsageId { get; set; }

        public string? SegmentationAux1 { get; set; }
        public Guid SegmentationAux1Id { get; set; }

        public string? SegmentationAux2 { get; set; }
        public Guid SegmentationAux2Id { get; set; }

        public string? SegmentationAux3 { get; set; }
        public Guid SegmentationAux3Id { get; set; }

        public string? SegmentationAux4 { get; set; }
        public Guid SegmentationAux4Id { get; set; }

        public string? SegmentationAux5 { get; set; }
        public Guid SegmentationAux5Id { get; set; }
    }

}
