using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.AltBodysts;
using LCH.MercedesBenz.Api.Models.Application.AltCategs;
using LCH.MercedesBenz.Api.Models.Application.AltSegms;
using LCH.MercedesBenz.Api.Models.Application.AMGCompSets;
using LCH.MercedesBenz.Api.Models.Application.ApertureFours;
using LCH.MercedesBenz.Api.Models.Application.AperturesOne;
using LCH.MercedesBenz.Api.Models.Application.AperturesTwo;
using LCH.MercedesBenz.Api.Models.Application.ApertureThrees;
using LCH.MercedesBenz.Api.Models.Application.AxleBases;
using LCH.MercedesBenz.Api.Models.Application.BodyStyles;
using LCH.MercedesBenz.Api.Models.Application.Bodyworks;
using LCH.MercedesBenz.Api.Models.Application.CabinCFs;
using LCH.MercedesBenz.Api.Models.Application.CabinSDs;
using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions;
using LCH.MercedesBenz.Api.Models.Application.Categories;
using LCH.MercedesBenz.Api.Models.Application.CatRules;
using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives;
using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs;
using LCH.MercedesBenz.Api.Models.Application.Configurations;
using LCH.MercedesBenz.Api.Models.Application.Doors;
using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;
using LCH.MercedesBenz.Api.Models.Application.Gears;
using LCH.MercedesBenz.Api.Models.Application.Groups;
using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts;
using LCH.MercedesBenz.Api.Models.Application.MotorDTs;
using LCH.MercedesBenz.Api.Models.Application.NIs;
using LCH.MercedesBenz.Api.Models.Application.PBTs;
using LCH.MercedesBenz.Api.Models.Application.PBTTNs;
using LCH.MercedesBenz.Api.Models.Application.Powers;
using LCH.MercedesBenz.Api.Models.Application.RelevMBs;
using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s;
using LCH.MercedesBenz.Api.Models.Application.Segments;
using LCH.MercedesBenz.Api.Models.Application.Sources;
using LCH.MercedesBenz.Api.Models.Application.SSegms;
using LCH.MercedesBenz.Api.Models.Application.Subsegments;
using LCH.MercedesBenz.Api.Models.Application.Tractions;
using LCH.MercedesBenz.Api.Models.Application.Usages;
using LCH.MercedesBenz.Api.Models.Application.WheelBases;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations
{
    [Table("InternalVersionSegmentations")]
    public class InternalVersionSegmentation : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid Cat_InternalVersionId { get; set; }

        public Cat_InternalVersion? Cat_InternalVersion { get; set; }

        [StringLength(4)]
        public string? MercedesVersionInternaId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public Category? Category { get; set; }

        [StringLength(3)]
        public string? MercedesCategoriaId { get; set; }

        [Required]
        public Guid SegmentId { get; set; }

        public Segment? Segment { get; set; }

        [StringLength(3)]
        public string? MercedesSegmentoId { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DischargeDate { get; set; } // Fecha de Alta

        [StringLength(60)]
        public string? Description { get; set; }

        [StringLength(3)]
        public string? AltBodystOLD { get; set; }

        [Required]
        public Guid AltBodystId { get; set; }

        public AltBodyst? AltBodyst { get; set; }

        [StringLength(3)]
        public string? AltCategOLD { get; set; }

        [Required]
        public Guid AltCategId { get; set; }
        public AltCateg? AltCateg { get; set; }

        [StringLength(3)]
        public string? AltSegmOLD { get; set; }

        [Required]
        public Guid AltSegmId { get; set; }
        public AltSegm? AltSegm { get; set; }

        [StringLength(3)]
        public string? AMGCompSetOLD { get; set; }

        [Required]
        public Guid AMGCompSetId { get; set; }
        public AMGCompSet? AMGCompSet { get; set; }

        [StringLength(3)]
        public string? Apertura1OLD { get; set; }

        [Required]
        public Guid ApertureOneId { get; set; }
        public ApertureOne? Apertura1 { get; set; }

        [StringLength(3)]
        public string? Apertura2OLD { get; set; }

        [Required]
        public Guid ApertureTwoId { get; set; }
        public ApertureTwo? Apertura2 { get; set; }

        [StringLength(3)]
        public string? Apertura3OLD { get; set; }

        [Required]
        public Guid ApertureThreeId { get; set; }
        public ApertureThree? Apertura3 { get; set; }

        [StringLength(3)]
        public string? Apertura4OLD { get; set; }

        [Required]
        public Guid ApertureFourId { get; set; }

        public ApertureFour? Apertura4 { get; set; }

        [StringLength(3)]
        public string? MercedesBodyStyle { get; set; }

        [Required]
        public Guid BodyStyleId { get; set; }

        [JsonIgnore]
        public BodyStyle? BodyStyle { get; set; }

        [StringLength(3)]
        public string? CabinaCFOLD { get; set; }

        [Required]
        public Guid CabinCFId { get; set; }
        public CabinCF? CabinaCF { get; set; }

        [StringLength(3)]
        public string? CabinaSDOLD { get; set; }

        [Required]
        public Guid CabinSDId { get; set; }
        public CabinSD? CabinaSD { get; set; }

        [StringLength(3)]
        public string? EngineCapacityOLD { get; set; } // Cilindrada(Cm3)

        [Required]
        public Guid EngineCapacityId { get; set; }
        public EngineCapacity? EngineCapacity { get; set; }

        [StringLength(3)]
        public string? CJDCompetitiveOLD { get; set; }

        [Required]
        public Guid CJDCompetitiveId { get; set; }
        public CJDCompetitive? CJDCompetitive { get; set; }

        [StringLength(3)]
        public string? FuelOLD { get; set; } // Combustible

        [Required]
        public Guid FuelTypeId { get; set; }
        public FuelType? FuelType { get; set; }

        [StringLength(3)]
        public string? CompetitiveCJDOLD { get; set; }
        [Required]
        public Guid CompetitiveCJDId { get; set; }
        public CompetitiveCJD? CompetitiveCJD { get; set; }

        [StringLength(3)]
        public string? MercedesConfiguration { get; set; } // Configuración
        
        public Guid? ConfigurationId { get; set; }

        [JsonIgnore]
        public Configuration? Configuration { get; set; }

        [Required]
        public Guid BodyworkId { get; set; }

        [JsonIgnore]
        public Bodywork? Bodywork { get; set; }

        [StringLength(3)]
        public string? WheelbaseOLD { get; set; }  // Distancia entre Ejes        

        [Required]
        public Guid WheelBaseId { get; set; }

        [JsonIgnore]
        public WheelBase? WheelBase { get; set; }

        [StringLength(3)]
        public string? AxleBaseOLD { get; set; } // Dist.Entre Ejes

        [Required]
        public Guid AxleBaseId { get; set; }

        [JsonIgnore]
        public AxleBase? AxleBase { get; set; }

        [StringLength(3)]
        public string? GroupOLD { get; set; } // Group(6)

        [Required]
        public Guid GroupId { get; set; }
        public Group? Group { get; set; }

        [StringLength(3)]
        public string? GearsOLD { get; set; } // Marchas

        [Required]
        public Guid GearId { get; set; }

        [JsonIgnore]
        public Gear? Gears { get; set; }

        [StringLength(3)]
        public string? MCGTotalMktOLD { get; set; }

        [Required]
        public Guid MCGTotalMktId { get; set; }

        public MCGTotalMkt? MCGTotalMkt { get; set; }

        [StringLength(3)]
        public string? MotorDTOLD { get; set; }

        [Required]
        public Guid MotorDTId { get; set; }

        public MotorDT? MotorDT { get; set; }

        [StringLength(3)]
        public string? NIOLD { get; set; }

        [Required]
        public Guid NIId { get; set; }
        public NI? NI { get; set; }

        [StringLength(3)]
        public string? Rule { get; set; }

        [StringLength(3)]
        public string? SourceOLD { get; set; }

        [Required]
        public Guid SourceId { get; set; }
        public Source? Source { get; set; }

        [StringLength(3)]
        public string? CatRuleOLD { get; set; }

        [Required]
        public Guid CatRuleId { get; set; }
        public CatRule? CatRule { get; set; }

        [StringLength(3)]
        public string? MercedesPBT { get; set; }

        [Required]
        public Guid PBTId { get; set; }

        [JsonIgnore]
        public PBT? PBT { get; set; }

        [Required]
        public Guid SubsegmentId { get; set; }

        [JsonIgnore]
        public Subsegment? Subsegment { get; set; }

        [StringLength(3)]
        public string? PBT_TNOLD { get; set; }

        [Required]
        public Guid PBTTNId { get; set; }
        public PBTTN? PBT_TN { get; set; }

        [StringLength(3)]
        public string? MercedesPower { get; set; }

        [Required]
        public Guid PowerId { get; set; }

        [JsonIgnore]
        public Power? Power { get; set; }

        [StringLength(3)]
        public string? DoorsOLD { get; set; }

        [Required]
        public Guid DoorId { get; set; }

        public Door? Doors { get; set; }

        [StringLength(3)]
        public string? RelevMBOLD { get; set; }

        [Required]
        public Guid RelevMBId { get; set; }
        public RelevMB? RelevMB { get; set; }

        [StringLength(3)]
        public string? SSegmOLD { get; set; }

        [Required]
        public Guid SSegmId { get; set; }
        public SSegm? SSegm { get; set; }

        [StringLength(3)]
        public string? MercedesTraction { get; set; }

        [Required]
        public Guid TractionId { get; set; }

        [JsonIgnore]
        public Traction? Traction { get; set; }

        [StringLength(3)]
        public string? MercedesUsage { get; set; }

        [Required]
        public Guid UsageId { get; set; }

        [JsonIgnore]
        public Usage? Usage { get; set; }

        [StringLength(3)]
        public string? SegmentationAux1OLD { get; set; }

        [Required]
        public Guid SegmentationAux1Id { get; set; }
        public SegmentationAux1? SegmentationAux1 { get; set; }

        [StringLength(3)]
        public string? SegmentationAux2 { get; set; }

        [StringLength(3)]
        public string? SegmentationAux3 { get; set; }

        [StringLength(3)]
        public string? SegmentationAux4 { get; set; }

        [StringLength(3)]
        public string? SegmentationAux5 { get; set; }

    }
}
