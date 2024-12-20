using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.AltBodysts.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AltCategs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AltSegms.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AMGCompSets.Dtos;
using LCH.MercedesBenz.Api.Models.Application.ApertureFours.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AperturesOne.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AperturesTwo.Dtos;
using LCH.MercedesBenz.Api.Models.Application.ApertureThrees.Dtos;
using LCH.MercedesBenz.Api.Models.Application.AxleBases.Dtos;
using LCH.MercedesBenz.Api.Models.Application.BodyStyles.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Bodyworks.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CabinCFs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CabinSDs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Categories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CatRules.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CJDCompetitives.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CompetitiveCJDs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Configurations.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Doors.Dtos;
using LCH.MercedesBenz.Api.Models.Application.EngineCapacitys.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Gears.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Groups.Dtos;
using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts.Dtos;
using LCH.MercedesBenz.Api.Models.Application.MotorDTs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.NIs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.PBTs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.PBTTNs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Powers.Dtos;
using LCH.MercedesBenz.Api.Models.Application.RelevMBs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.SegmentationAux1s.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Segments.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Sources.Dtos;
using LCH.MercedesBenz.Api.Models.Application.SSegms.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Subsegments.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Tractions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Usages.Dtos;
using LCH.MercedesBenz.Api.Models.Application.WheelBases.Dtos;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations.Dtos
{
    public class InternalVersionSegmentationDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid Cat_InternalVersionId { get; set; }

        public Cat_InternalVersionDto? Cat_InternalVersion { get; set; }

        public string? MercedesVersionInternaId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public CategoryDto? Category { get; set; }

        public string? MercedesCategoriaId { get; set; }

        [Required]
        public Guid SegmentId { get; set; }

        public SegmentDto? Segment { get; set; }

        public string? MercedesSegmentoId { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DischargeDate { get; set; } // Fecha de Alta

        public string? Description { get; set; }

        public Guid AltBodystId { get; set; }

        public AltBodystDto? AltBodyst { get; set; }

        public Guid AltCategId { get; set; }

        public AltCategDto? AltCateg { get; set; }

        public Guid AltSegmId { get; set; }

        public AltSegmDto? AltSegm { get; set; }

        public Guid AMGCompSetId { get; set; }

        public AMGCompSetDto? AMGCompSet { get; set; }

        public Guid Apertura1Id { get; set; }

        public ApertureOneDto? Apertura1 { get; set; }

        public Guid Apertura2Id { get; set; }

        public ApertureTwoDto? Apertura2 { get; set; }

        public Guid Apertura3Id { get; set; }

        public ApertureThreeDto? Apertura3 { get; set; }

        public Guid Apertura4Id { get; set; }

        public ApertureFourDto? Apertura4 { get; set; }

        public string? MercedesBodyStyle { get; set; }

        public Guid BodyStyleId { get; set; }

        public BodyStyleDto? BodyStyle { get; set; }

        public Guid CabinaCFId { get; set; }

        public CabinCFDto? CabinaCF { get; set; }

        public Guid CabinaSDId { get; set; }

        public CabinSDDto? CabinaSD { get; set; }

        public Guid EngineCapacityId { get; set; }

        public EngineCapacityDto? EngineCapacity { get; set; }

        public Guid CJDCompetitiveId { get; set; }

        public CJDCompetitiveDto? CJDCompetitive { get; set; }

        public Guid FuelTypeId { get; set; }

        public FuelTypeDto? FuelType { get; set; }

        public Guid CompetitiveCJDId { get; set; }

        public CompetitiveCJDDto? CompetitiveCJD { get; set; }

        public Guid MercedesConfigurationId { get; set; }

        public ConfigurationDto? MercedesConfiguration { get; set; }

        public Guid BodyworkId { get; set; }

        public BodyworkDto? Bodywork { get; set; }

        public Guid WheelBaseId { get; set; } // Distancia entre Ejes

        public WheelBaseDto? WheelBase { get; set; }

        public Guid AxleBaseId { get; set; } // Dist. Entre Ejes

        public AxleBaseDto? AxleBase { get; set; }

        public Guid GroupId { get; set; }

        public GroupDto? Group { get; set; }

        public Guid GearsId { get; set; } // Marchas

        public GearDto? Gears { get; set; }

        public Guid MCGTotalMktId { get; set; }

        public MCGTotalMktDto? MCGTotalMkt { get; set; }

        public Guid MotorDTId { get; set; }

        public MotorDTDto? MotorDT { get; set; }

        public Guid NIId { get; set; }

        public NIDto? NI { get; set; }

        public Guid CatRuleId { get; set; }

        public CatRuleDto? CatRule { get; set; }

        public Guid SourceId { get; set; }

        public SourceDto? Source { get; set; }

        public Guid MercedesPBTId { get; set; }

        public PBTDto? MercedesPBT { get; set; }

        public Guid SubsegmentId { get; set; }

        public SubsegmentDto? Subsegment { get; set; }

        public Guid PBT_TNId { get; set; }

        public PBTTNDto? PBT_TN { get; set; }

        public string? MercedesPower { get; set; }

        public Guid PowerId { get; set; }

        public PowerDto? Power { get; set; }

        public Guid DoorsId { get; set; }

        public DoorDto? Doors { get; set; }

        public Guid RelevMBId { get; set; }

        public RelevMBDto? RelevMB { get; set; }

        public Guid SSegmId { get; set; }

        public SSegmDto? SSegm { get; set; }

        public string? MercedesTraction { get; set; }

        public Guid TractionId { get; set; }

        public TractionDto? Traction { get; set; }

        public string? MercedesUsage { get; set; }

        public Guid UsageId { get; set; }

        public UsageDto? Usage { get; set; }

        public Guid SegmentationAux1Id { get; set; }

        public SegmentationAux1Dto? SegmentationAux1 { get; set; }

        public string? SegmentationAux2 { get; set; }

        public string? SegmentationAux3 { get; set; }

        public string? SegmentationAux4 { get; set; }

        public string? SegmentationAux5 { get; set; }
    }
}
