using AutoMapper;
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
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CabinCFs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CabinSDs.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
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
using LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations.Dtos;
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
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Tractions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Usages.Dtos;
using LCH.MercedesBenz.Api.Models.Application.WheelBases.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations
{
    public class InternalVersionSegmentationRepository : BaseRepository<InternalVersionSegmentation>, IInternalVersionSegmentationRepository
    {
        private readonly IMapper _mapper;

        public InternalVersionSegmentationRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<InternalVersionSegmentationDto> GetAll2()
        {
            try
            {
                var results = Context.InternalVersionSegmentations.Select(i => new InternalVersionSegmentationDto
                {
                    //InternalVersionId = i.InternalVersionId,
                    //InternalVersion = i.InternalVersion == null ? null : new InternalVersionDto
                    //{
                    //    Id = i.InternalVersion.Id,
                    //    MercedesMarcaId = i.InternalVersion.MercedesMarcaId,
                    //    CarModelId = i.InternalVersion.CarModelId,
                    //    MercedesModeloId = i.InternalVersion.MercedesModeloId,
                    //    MercedesTerminalId = i.InternalVersion.MercedesTerminalId,
                    //    VersionPatentamiento = i.InternalVersion.VersionPatentamiento,
                    //    VersionWs = i.InternalVersion.VersionWs,
                    //    VersionInterna = i.InternalVersion.VersionInterna,
                    //    DescripcionVerInt = i.InternalVersion.DescripcionVerInt,
                    //    UploadDate = i.InternalVersion.UploadDate,
                    //    DateTo = i.InternalVersion.DateTo,
                    //    DateFrom = i.InternalVersion.DateFrom
                    //},
                    Id = i.Id,
                    Cat_InternalVersionId = i.Cat_InternalVersionId,
                    Cat_InternalVersion = i.Cat_InternalVersion == null ? null : new Cat_InternalVersionDto
                    {
                        Id = i.Cat_InternalVersion.Id,
                        CarModelId = i.Cat_InternalVersion.CarModelId,
                        MercedesTerminalId = i.Cat_InternalVersion.MercedesTerminalId,
                        MercedesMarcaId = i.Cat_InternalVersion.MercedesMarcaId,
                        MercedesModeloId = i.Cat_InternalVersion.MercedesModeloId,                             
                        Version = i.Cat_InternalVersion.Version,
                        Description = i.Cat_InternalVersion.Description,
                        DateTo = i.Cat_InternalVersion.DateTo,
                        DateFrom = i.Cat_InternalVersion.DateFrom
                    },
                    MercedesVersionInternaId = i.MercedesVersionInternaId,
                    CategoryId = i.CategoryId,
                    Category = i.Category == null ? null : new CategoryDto
                    {
                        Id = i.Category.Id,
                        SegCategory = i.Category.SegCategory,
                        Description = i.Category.Description
                    },
                    MercedesCategoriaId = i.MercedesCategoriaId,
                    SegmentId = i.SegmentId,
                    Segment = i.Segment == null ? null : new SegmentDto
                    {
                        Id = i.Segment.Id,
                        MercedesCategoriaId = i.Segment.MercedesCategoriaId,
                        SegName = i.Segment.SegName,
                        DescriptionShort = i.Segment.DescriptionShort,
                        DescriptionLong = i.Segment.DescriptionLong
                    },
                    MercedesSegmentoId = i.MercedesSegmentoId,
                    DischargeDate = i.DischargeDate,
                    Description = i.Description,
                    AltBodystId = i.AltBodystId,
                    AltBodyst = i.AltBodyst == null ? null : new AltBodystDto
                    {
                        Id = i.AltBodyst.Id,
                        MercedesAltBodyst = i.AltBodyst.MercedesAltBodyst,
                        Description = i.AltBodyst.Description,
                        SegCategory = i.AltBodyst.SegCategory
                    },
                    AltCategId = i.AltCategId,
                    AltCateg = i.AltCateg == null ? null : new AltCategDto
                    {
                        Id = i.AltCateg.Id,
                        MercedesAltCateg = i.AltCateg.MercedesAltCateg,
                        Description = i.AltCateg.Description,
                        SegCategory = i.AltCateg.SegCategory
                    },
                    AltSegmId = i.AltSegmId,
                    AltSegm = i.AltSegm == null ? null : new AltSegmDto
                    {
                        Id = i.AltSegm.Id,
                        MercedesAltSegm = i.AltSegm.MercedesAltSegm,
                        Description = i.AltSegm.Description,
                        SegCategory = i.AltSegm.SegCategory
                    },
                    AMGCompSetId = i.AMGCompSetId,
                    AMGCompSet = i.AMGCompSet == null ? null : new AMGCompSetDto
                    {
                        Id = i.AMGCompSet.Id,
                        MercedesAMGCompSet = i.AMGCompSet.MercedesAMGCompSet,
                        Description = i.AMGCompSet.Description,
                        SegCategory = i.AMGCompSet.SegCategory
                    },
                    Apertura1Id = i.ApertureOneId,
                    Apertura1 = i.Apertura1 == null ? null : new ApertureOneDto
                    {
                        Id = i.Apertura1.Id,
                        MercedesApertureOne = i.Apertura1.MercedesApertureOne,
                        DescriptionLong = i.Apertura1.DescriptionLong,
                        DescriptionShort = i.Apertura1.DescriptionShort
                    },
                    Apertura2Id = i.ApertureTwoId,
                    Apertura2 = i.Apertura2 == null ? null : new ApertureTwoDto
                    {
                        Id = i.Apertura2.Id,
                        MercedesApertureTwo = i.Apertura2.MercedesApertureTwo,
                        DescriptionLong = i.Apertura2.DescriptionLong,
                        DescriptionShort = i.Apertura2.DescriptionShort
                    },
                    Apertura3Id = i.ApertureThreeId,
                    Apertura3 = i.Apertura3 == null ? null : new ApertureThreeDto
                    {
                        Id = i.Apertura3.Id,
                        MercedesApertureThree = i.Apertura3.MercedesApertureThree,
                        Description = i.Apertura3.Description,
                        SegCategory = i.Apertura3.SegCategory
                    },
                    Apertura4Id = i.ApertureFourId,
                    Apertura4 = i.Apertura4 == null ? null : new ApertureFourDto
                    {
                        Id = i.Apertura4.Id,
                        MercedesApertureFour = i.Apertura4.MercedesApertureFour,
                        Description = i.Apertura4.Description,
                        SegCategory = i.Apertura4.SegCategory
                    },
                    MercedesBodyStyle = i.MercedesBodyStyle,
                    BodyStyleId = i.BodyStyleId,
                    BodyStyle = i.BodyStyle == null ? null : new BodyStyleDto
                    {
                        Id = i.BodyStyle.Id,
                        MercedesBodyStyle = i.BodyStyle.MercedesBodyStyle,
                        Description = i.BodyStyle.Description,
                        SegCategory = i.BodyStyle.SegCategory
                    },
                    CabinaCFId = i.CabinCFId,
                    CabinaCF = i.CabinaCF == null ? null : new CabinCFDto
                    {
                        Id = i.CabinaCF.Id,
                        MercedesCabinCF = i.CabinaCF.MercedesCabinCF,
                        Description = i.CabinaCF.Description,
                        SegCategory = i.CabinaCF.SegCategory
                    },
                    CabinaSDId = i.CabinSDId,
                    CabinaSD = i.CabinaSD == null ? null : new CabinSDDto
                    {
                        Id = i.CabinaSD.Id,
                        MercedesCabinSD = i.CabinaSD.MercedesCabinSD,
                        Description = i.CabinaSD.Description,
                        SegCategory = i.CabinaSD.SegCategory
                    },
                    EngineCapacityId = i.EngineCapacityId,
                    EngineCapacity = i.EngineCapacity == null ? null : new EngineCapacityDto
                    {
                        Id = i.EngineCapacity.Id,
                        MercedesEngineCapacity = i.EngineCapacity.MercedesEngineCapacity,
                        Description = i.EngineCapacity.Description,
                        SegCategory = i.EngineCapacity.SegCategory
                    },
                    CompetitiveCJDId = i.CompetitiveCJDId,
                    CompetitiveCJD = i.CompetitiveCJD == null ? null : new CompetitiveCJDDto
                    {
                        Id = i.CompetitiveCJD.Id,
                        MercedesCompetitiveCJD = i.CompetitiveCJD.MercedesCompetitiveCJD,
                        Description = i.CompetitiveCJD.Description,
                        SegCategory = i.CompetitiveCJD.SegCategory
                    },
                    FuelTypeId = i.FuelTypeId,
                    FuelType = i.FuelType == null ? null : new FuelTypeDto
                    {
                        Id = i.FuelType.Id,
                        MercedesFuelType = i.FuelType.MercedesFuelType,
                        Description = i.FuelType.Description,
                        SegCategory = i.FuelType.SegCategory
                    },
                    CJDCompetitiveId = i.CJDCompetitiveId,
                    CJDCompetitive = i.CJDCompetitive == null ? null : new CJDCompetitiveDto
                    {
                        Id = i.CJDCompetitive.Id,
                        MercedesCJDCompetitive = i.CJDCompetitive.MercedesCJDCompetitive,
                        Description = i.CJDCompetitive.Description,
                        SegCategory = i.CJDCompetitive.SegCategory
                    },
                    //MercedesConfiguration = i.Configuration.MercedesConfiguration,
                    MercedesConfigurationId = i.Configuration.Id,
                    MercedesConfiguration = i.Configuration == null ? null : new ConfigurationDto
                    {
                        Id = i.Configuration.Id,
                        MercedesConfiguration = i.Configuration.MercedesConfiguration,
                        Description = i.Configuration.Description,
                        SegCategory = i.Configuration.SegCategory
                    },
                    BodyworkId = i.BodyworkId,
                    Bodywork = i.Bodywork == null ? null : new BodyworkDto
                    {
                        Id = i.Bodywork.Id,
                        MercedesBodywork = i.Bodywork.MercedesBodywork,
                        Description = i.Bodywork.Description,
                        SegCategory = i.Bodywork.SegCategory
                    },
                    WheelBaseId = i.WheelBaseId,
                    WheelBase = i.WheelBase == null ? null : new WheelBaseDto
                    {
                        Id = i.WheelBase.Id,
                        MercedesWheelBase = i.WheelBase.MercedesWheelBase,
                        Description = i.WheelBase.Description,
                        SegCategory = i.WheelBase.SegCategory
                    },
                    AxleBaseId = i.AxleBaseId,
                    AxleBase = i.AxleBase == null ? null : new AxleBaseDto
                    {
                        Id = i.AxleBase.Id,
                        MercedesAxleBase = i.AxleBase.MercedesAxleBase,
                        Description = i.AxleBase.Description,
                        SegCategory = i.AxleBase.SegCategory
                    },
                    GroupId = i.GroupId,
                    Group = i.Group == null ? null : new GroupDto
                    {
                        Id = i.Group.Id,
                        MercedesGroup = i.Group.MercedesGroup,
                        Description = i.Group.Description,
                        SegCategory = i.Group.SegCategory
                    },
                    GearsId = i.GearId,
                    Gears = i.Gears == null ? null : new GearDto
                    {
                        Id = i.Gears.Id,
                        MercedesGear = i.Gears.MercedesGear,
                        Description = i.Gears.Description,
                        SegCategory = i.Gears.SegCategory
                    },
                    SourceId = i.SourceId,
                    Source = i.Source == null ? null : new SourceDto
                    {
                        Id = i.Source.Id,
                        MercedesSource = i.Source.MercedesSource,
                        Description = i.Source.Description,
                        SegCategory = i.Source.SegCategory
                    },
                    NIId = i.NIId,
                    NI = i.NI == null ? null : new NIDto
                    {
                        Id = i.NI.Id,
                        MercedesNI = i.NI.MercedesNI,
                        Description = i.NI.Description,
                        SegCategory = i.NI.SegCategory
                    },
                    MCGTotalMktId = i.MCGTotalMktId,
                    MCGTotalMkt = i.MCGTotalMkt == null ? null : new MCGTotalMktDto
                    {
                        Id = i.MCGTotalMkt.Id,
                        MercedesMCGTotalMkt = i.MCGTotalMkt.MercedesMCGTotalMkt,
                        Description = i.MCGTotalMkt.Description,
                        SegCategory = i.MCGTotalMkt.SegCategory
                    },
                    MotorDTId = i.MotorDTId,
                    MotorDT = i.MotorDT == null ? null : new MotorDTDto
                    {
                        Id = i.MotorDT.Id,
                        MercedesMotorDT = i.MotorDT.MercedesMotorDT,
                        Description = i.MotorDT.Description,
                        SegCategory = i.MotorDT.SegCategory
                    },
                    //Rule = i.CatRule.MercedesCatRule,
                    CatRuleId = i.CatRuleId,
                    CatRule = i.CatRule == null ? null : new CatRuleDto
                    {
                        Id = i.CatRule.Id,
                        MercedesCatRule = i.CatRule.MercedesCatRule,
                        Description = i.CatRule.Description,
                        SegCategory = i.CatRule.SegCategory
                    },
                    MercedesPBTId = i.PBTId,
                    MercedesPBT = i.MercedesPBT == null ? null : new PBTDto
                    {
                        Id = i.PBT.Id,
                        MercedesPBT = i.PBT.MercedesPBT,
                        Description = i.PBT.Description,
                        SegCategory = i.PBT.SegCategory
                    },
                    SubsegmentId = i.SubsegmentId,
                    Subsegment = i.Subsegment == null ? null : new SubsegmentDto
                    {
                        Id = i.Subsegment.Id,
                        MercedesSubsegment = i.Subsegment.MercedesSubsegment,
                        Description = i.Subsegment.Description,
                        SegCategory = i.Subsegment.SegCategory
                    },
                    PBT_TNId = i.PBTTNId,
                    PBT_TN = i.PBT_TN == null ? null : new PBTTNDto
                    {
                        Id = i.PBT_TN.Id,
                        MercedesPBTTN = i.PBT_TN.MercedesPBTTN,
                        Description = i.PBT_TN.Description,
                        SegCategory = i.PBT_TN.SegCategory
                    },
                    MercedesPower = i.MercedesPower,
                    PowerId = i.PowerId,
                    Power = i.Power == null ? null : new PowerDto
                    {
                        Id = i.Power.Id,
                        MercedesPower = i.Power.MercedesPower,
                        Description = i.Power.Description,
                        SegCategory = i.Power.SegCategory
                    },
                    DoorsId = i.DoorId,
                    Doors = i.Doors == null ? null : new DoorDto
                    {
                        Id = i.Doors.Id,
                        MercedesDoor = i.Doors.MercedesDoor,
                        Description = i.Doors.Description,
                        SegCategory = i.Doors.SegCategory
                    },
                    RelevMBId = i.RelevMBId,
                    RelevMB = i.RelevMB == null ? null : new RelevMBDto
                    {
                        Id = i.RelevMB.Id,
                        MercedesRelevMB = i.RelevMB.MercedesRelevMB,
                        Description = i.RelevMB.Description,
                        SegCategory = i.RelevMB.SegCategory
                    },
                    SSegmId = i.SSegmId,
                    SSegm = i.SSegm == null ? null : new SSegmDto
                    {
                        Id = i.SSegm.Id,
                        MercedesSSegm = i.SSegm.MercedesSSegm,
                        Description = i.SSegm.Description,
                        SegCategory = i.SSegm.SegCategory
                    },
                    MercedesTraction = i.MercedesTraction,
                    TractionId = i.TractionId,
                    Traction = i.Traction == null ? null : new TractionDto
                    {
                        Id = i.Traction.Id,
                        MercedesTraction = i.Traction.MercedesTraction,
                        Description = i.Traction.Description,
                        SegCategory = i.Traction.SegCategory
                    },
                    MercedesUsage = i.MercedesUsage,
                    UsageId = i.UsageId,
                    Usage = i.Usage == null ? null : new UsageDto
                    {
                        Id = i.Usage.Id,
                        MercedesUsage = i.Usage.MercedesUsage,
                        Description = i.Usage.Description,
                        SegCategory = i.Usage.SegCategory
                    },
                    SegmentationAux1Id = i.SegmentationAux1Id,
                    SegmentationAux1 = i.SegmentationAux1 == null ? null : new SegmentationAux1Dto
                    {
                        Id = i.SegmentationAux1.Id,
                        MercedesSegmentationAux1 = i.SegmentationAux1.MercedesSegmentationAux1,
                        Description = i.SegmentationAux1.Description,
                        SegCategory = i.SegmentationAux1.SegCategory
                    },
                    SegmentationAux2 = i.SegmentationAux2,
                    SegmentationAux3 = i.SegmentationAux3,
                    SegmentationAux4 = i.SegmentationAux4,
                    SegmentationAux5 = i.SegmentationAux5,
                }).OrderBy(i => i.Id).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<InternalVersionSegmentationDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<InternalVersionSegmentationDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<InternalVersionSegmentation> Create(InternalVersionSegmentationDto dto)
        {
            try
            {
                var entity = Context.InternalVersionSegmentations.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status400BadRequest, $"La Segmentación ya existe.");
                entity = _mapper.Map<InternalVersionSegmentation>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                var param = new SqlParameter { ParameterName = "@ivsId", Value = entity.Id };
                var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_actualizaVersionClave] @ivsId", param);
                return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        
        public BaseResponse<InternalVersionSegmentation> Update(InternalVersionSegmentationUpdateDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.InternalVersionSegmentations.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status400BadRequest, $"Id de Segmentación no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                var param = new SqlParameter { ParameterName = "@ivsId", Value = dto.Id };
                var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_actualizaVersionClave] @ivsId", param);
                return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> GetCatalogs()
        {
                try
                {
                Dictionary<string, IEnumerable<dynamic>> results = new Dictionary<string, IEnumerable<dynamic>>();

                var catInternalVersion = Context.Cat_InternalVersions.Select(i => new Cat_InternalVersionDto
                {
                    Id = i.Id,
                    MercedesMarcaId = i.MercedesMarcaId,
                    CarModelId = i.CarModelId,
                    CarModel = i.CarModel == null ? null : new CarModelDto
                    {
                        Id = i.CarModel.Id,
                        Name = i.CarModel.Name,
                        Description = i.CarModel.Description,
                        MercedesTerminalId = i.CarModel.MercedesTerminalId,
                        MercedesMarcaId = i.CarModel.MercedesMarcaId,
                        MercedesModeloId = i.CarModel.MercedesModeloId,
                        BrandId = i.CarModel.BrandId,
                        Brand = i.CarModel.Brand == null ? null : new BrandDto
                        {
                            Id = i.CarModel.Brand.Id,
                            Name = i.CarModel.Brand.Name,
                            TerminalId = i.CarModel.Brand.TerminalId,
                            Terminal = i.CarModel.Brand.Terminal == null ? null : new TerminalDto
                            {
                                Id = i.CarModel.Brand.Terminal.Id,
                                Name = i.CarModel.Brand.Terminal.Name
                            }
                        }
                    },
                    MercedesModeloId = i.MercedesModeloId,
                    MercedesTerminalId = i.MercedesTerminalId,
                    Version = i.Version, 
                    Description = i.Description, 
                    DateTo = i.DateTo,
                    DateFrom = i.DateFrom
                }).OrderBy(i => i.Version).ToList();
                var noAssignedInternalVersion = catInternalVersion.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedInternalVersion != null)
                    catInternalVersion.Remove(noAssignedInternalVersion);
                var categories = Context.Categories.Select(i => new CategoryDto
                {
                    Id = i.Id,
                    SegCategory = i.SegCategory,
                    Description = i.Description
                }).OrderBy(i => i.SegCategory).ToList();
                var noAssignedCategory = categories.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedCategory != null)
                    categories.Remove(noAssignedCategory);
                var segments = Context.Segments.Select(i => new SegmentDto
                {
                    Id = i.Id,
                    MercedesCategoriaId = i.MercedesCategoriaId,
                    SegName = i.SegName,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong
                }).OrderBy(i => i.Id).ToList();
                var noAssignedSegment = segments.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedSegment != null)
                    segments.Remove(noAssignedSegment);
                var bodystyles = Context.BodyStyles.Select(i => new BodyStyleDto
                {
                    Id = i.Id,
                    MercedesBodyStyle = i.MercedesBodyStyle,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesBodyStyle).ToList();
                var noAssignedBodyStyle = bodystyles.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedBodyStyle != null)
                    bodystyles.Remove(noAssignedBodyStyle);
                var bodyworks = Context.Bodyworks.Select(i => new BodyworkDto
                {
                    Id = i.Id,
                    MercedesBodywork = i.MercedesBodywork,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesBodywork).ToList();
                var noAssignedBodywork = bodyworks.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedBodywork != null)
                    bodyworks.Remove(noAssignedBodywork);
                var subsegments = Context.Subsegments.Select(i => new SubsegmentDto
                {
                    Id = i.Id,
                    MercedesSubsegment = i.MercedesSubsegment,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSubsegment).ToList();
                var noAssignedSubsegment = subsegments.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedSubsegment != null)
                    subsegments.Remove(noAssignedSubsegment);
                var usages = Context.Usages.Select(i => new UsageDto
                {
                    Id = i.Id,
                    MercedesUsage = i.MercedesUsage,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesUsage).ToList();
                var noAssignedUsage = usages.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedUsage != null)
                    usages.Remove(noAssignedUsage);
                var tractions = Context.Tractions.Select(i => new TractionDto
                {
                    Id = i.Id,
                    MercedesTraction = i.MercedesTraction,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesTraction).ToList();
                var noAssignedTraction = tractions.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedTraction != null)
                    tractions.Remove(noAssignedTraction);
                var fuelTypes = Context.FuelTypes.Select(i => new FuelTypeDto
                {
                    Id = i.Id,
                    MercedesFuelType = i.MercedesFuelType,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesFuelType).ToList();
                var noAssignedFuelType = fuelTypes.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedFuelType != null)
                    fuelTypes.Remove(noAssignedFuelType);
                var cabinCFs = Context.CabinCFs.Select(i => new CabinCFDto
                {
                    Id = i.Id,
                    MercedesCabinCF = i.MercedesCabinCF,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCabinCF).ToList();
                var noAssignedCabinCF = cabinCFs.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedCabinCF != null)
                    cabinCFs.Remove(noAssignedCabinCF);
                var wheelBases = Context.WheelBases.Select(i => new WheelBaseDto
                {
                    Id = i.Id,
                    MercedesWheelBase = i.MercedesWheelBase,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesWheelBase).ToList();
                var noAssignedWheelBase = wheelBases.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedWheelBase != null)
                    wheelBases.Remove(noAssignedWheelBase);
                var axleBases = Context.AxleBases.Select(i => new AxleBaseDto
                {
                    Id = i.Id,
                    MercedesAxleBase = i.MercedesAxleBase,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAxleBase).ToList();
                var noAssignedAxleBase = axleBases.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAxleBase != null)
                    axleBases.Remove(noAssignedAxleBase);
                var gears = Context.Gears.Select(i => new GearDto
                {
                    Id = i.Id,
                    MercedesGear = i.MercedesGear,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesGear).ToList();
                var noAssignedGear = gears.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedGear != null)
                    gears.Remove(noAssignedGear);
                var doors = Context.Doors.Select(i => new DoorDto
                {
                    Id = i.Id,
                    MercedesDoor = i.MercedesDoor,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesDoor).ToList();
                var noAssignedDoor = doors.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedDoor != null)
                    doors.Remove(noAssignedDoor);
                var sources = Context.Sources.Select(i => new SourceDto
                {
                    Id = i.Id,
                    MercedesSource = i.MercedesSource,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSource).ToList();
                var noAssignedSources = sources.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedSources != null)
                    sources.Remove(noAssignedSources);
                var mcgTotalMkts = Context.MCGTotalMkts.Select(i => new MCGTotalMktDto
                {
                    Id = i.Id,
                    MercedesMCGTotalMkt = i.MercedesMCGTotalMkt,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesMCGTotalMkt).ToList();
                var noAssignedMcgTotalMkts = mcgTotalMkts.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedMcgTotalMkts != null)
                    mcgTotalMkts.Remove(noAssignedMcgTotalMkts);
                var motorDTs = Context.MotorDTs.Select(i => new MotorDTDto
                {
                    Id = i.Id,
                    MercedesMotorDT = i.MercedesMotorDT,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesMotorDT).ToList();
                var noAssignedMotorDTs = motorDTs.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedMotorDTs != null)
                    motorDTs.Remove(noAssignedMotorDTs);
                var aperturesThree = Context.AperturesThree.Select(i => new ApertureThreeDto
                {
                    Id = i.Id,
                    MercedesApertureThree = i.MercedesApertureThree,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesApertureThree).ToList();
                var noAssignedAperturesThree = aperturesThree.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAperturesThree != null)
                    aperturesThree.Remove(noAssignedAperturesThree);
                var aperturesFour = Context.AperturesFour.Select(i => new ApertureFourDto
                {
                    Id = i.Id,
                    MercedesApertureFour = i.MercedesApertureFour,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesApertureFour).ToList();
                var noAssignedAperturesFour = aperturesFour.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAperturesFour != null)
                    aperturesFour.Remove(noAssignedAperturesFour);
                var aperturesOne = Context.AperturesOne.Select(i => new ApertureOneDto
                {
                    Id = i.Id,
                    MercedesApertureOne = i.MercedesApertureOne,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesApertureOne).ToList();
                var noAssignedAperturesOne = aperturesOne.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAperturesOne != null)
                    aperturesOne.Remove(noAssignedAperturesOne);
                var aperturesTwo = Context.AperturesTwo.Select(i => new ApertureTwoDto
                {
                    Id = i.Id,
                    MercedesApertureTwo = i.MercedesApertureTwo,
                    DescriptionShort = i.DescriptionShort,
                    DescriptionLong = i.DescriptionLong,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesApertureTwo).ToList();
                var noAssignedAperturesTwo = aperturesTwo.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAperturesTwo != null)
                    aperturesTwo.Remove(noAssignedAperturesTwo);
                var cjdCompetitive = Context.CJDCompetitives.Select(i => new CJDCompetitiveDto
                {
                    Id = i.Id,
                    MercedesCJDCompetitive = i.MercedesCJDCompetitive,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCJDCompetitive).ToList();
                var noAssignedCjdCompetitives = cjdCompetitive.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedCjdCompetitives != null)
                    cjdCompetitive.Remove(noAssignedCjdCompetitives);
                var engineCapacitys = Context.EngineCapacitys.Select(i => new EngineCapacityDto
                {
                    Id = i.Id,
                    MercedesEngineCapacity = i.MercedesEngineCapacity,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesEngineCapacity).ToList();
                var noAssignedEngineCapacitys = engineCapacitys.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedEngineCapacitys != null)
                    engineCapacitys.Remove(noAssignedEngineCapacitys);
                var pbts = Context.PBTs.Select(i => new PBTDto
                {
                    Id = i.Id,
                    MercedesPBT = i.MercedesPBT,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesPBT).ToList();
                var noAssignedPbts = pbts.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedPbts != null)
                    pbts.Remove(noAssignedPbts);
                var cabinSDs = Context.CabinSDs.Select(i => new CabinSDDto
                {
                    Id = i.Id,
                    MercedesCabinSD = i.MercedesCabinSD,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCabinSD).ToList();
                var noAssignedCabin = cabinSDs.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedCabin != null)
                    cabinSDs.Remove(noAssignedCabin);
                var competitiveCJDs = Context.CompetitiveCJDs.Select(i => new CompetitiveCJDDto
                {
                    Id = i.Id,
                    MercedesCompetitiveCJD = i.MercedesCompetitiveCJD,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCompetitiveCJD).ToList();
                var noAssignedCompetitiveCJD = competitiveCJDs.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedCompetitiveCJD != null)
                    competitiveCJDs.Remove(noAssignedCompetitiveCJD);
                var configurations = Context.Configurations.Select(i => new ConfigurationDto
                {
                    Id = i.Id,
                    MercedesConfiguration = i.MercedesConfiguration,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesConfiguration).ToList();
                var noAssignedConfiguration = configurations.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedConfiguration != null)
                    configurations.Remove(noAssignedConfiguration);
                var altBodysts = Context.AltBodysts.Select(i => new AltBodystDto
                {
                    Id = i.Id,
                    MercedesAltBodyst = i.MercedesAltBodyst,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAltBodyst).ToList();
                var noAssignedAltBodyst = altBodysts.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAltBodyst != null)
                    altBodysts.Remove(noAssignedAltBodyst);
                var altCategs = Context.AltCategs.Select(i => new AltCategDto
                {
                    Id = i.Id,
                    MercedesAltCateg = i.MercedesAltCateg,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAltCateg).ToList();
                var noAssignedAltCateg = altCategs.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAltCateg != null)
                    altCategs.Remove(noAssignedAltCateg);
                var altSegms = Context.AltSegms.Select(i => new AltSegmDto
                {
                    Id = i.Id,
                    MercedesAltSegm = i.MercedesAltSegm,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAltSegm).ToList();
                var noAssignedAltSegm = altSegms.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAltSegm != null)
                    altSegms.Remove(noAssignedAltSegm);
                var amgCompSets = Context.AMGCompSets.Select(i => new AMGCompSetDto
                {
                    Id = i.Id,
                    MercedesAMGCompSet = i.MercedesAMGCompSet,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesAMGCompSet).ToList();
                var noAssignedAMGCompSet = amgCompSets.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedAMGCompSet != null)
                    amgCompSets.Remove(noAssignedAMGCompSet);
                var pbttns = Context.PBTTNs.Select(i => new PBTTNDto
                {
                    Id = i.Id,
                    MercedesPBTTN = i.MercedesPBTTN,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesPBTTN).ToList();
                var noAssignedPBTTN = pbttns.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedPBTTN != null)
                    pbttns.Remove(noAssignedPBTTN);
                var nis = Context.NIs.Select(i => new NIDto
                {
                    Id = i.Id,
                    MercedesNI = i.MercedesNI,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesNI).ToList();
                var noAssignedNI = nis.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedNI != null)
                    nis.Remove(noAssignedNI);
                var RelevMBs = Context.RelevMBs.Select(i => new RelevMBDto
                {
                    Id = i.Id,
                    MercedesRelevMB = i.MercedesRelevMB,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesRelevMB).ToList();
                var noAssignedRelevMB = RelevMBs.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedRelevMB != null)
                    RelevMBs.Remove(noAssignedRelevMB);
                var SegmentationAux1s = Context.SegmentationAux1s.Select(i => new SegmentationAux1Dto
                {
                    Id = i.Id,
                    MercedesSegmentationAux1 = i.MercedesSegmentationAux1,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSegmentationAux1).ToList();
                var noAssignedSegmentationAux1 = SegmentationAux1s.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedSegmentationAux1 != null)
                    SegmentationAux1s.Remove(noAssignedSegmentationAux1);
                var SSegms = Context.SSegms.Select(i => new SSegmDto
                {
                    Id = i.Id,
                    MercedesSSegm = i.MercedesSSegm,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesSSegm).ToList();
                var noAssignedSSegm = SSegms.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedSSegm != null)
                    SSegms.Remove(noAssignedSSegm);
                var Groups = Context.Groups.Select(i => new GroupDto
                {
                    Id = i.Id,
                    MercedesGroup = i.MercedesGroup,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesGroup).ToList();
                var noAssignedGroup = Groups.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedGroup != null)
                    Groups.Remove(noAssignedGroup);
                var catRules = Context.CatRules.Select(i => new CatRuleDto
                {
                    Id = i.Id,
                    MercedesCatRule = i.MercedesCatRule,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesCatRule).ToList();
                var noAssignedCatRule = catRules.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedCatRule != null)
                    catRules.Remove(noAssignedCatRule);
                var powers = Context.Powers.Select(i => new PowerDto
                {
                    Id = i.Id,
                    MercedesPower = i.MercedesPower,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesPower).ToList();
                var noAssignedPower = powers.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssignedPower != null)
                    powers.Remove(noAssignedPower);
                results.Add("internalVersions", catInternalVersion);
                results.Add("categories", categories);
                results.Add("segments", segments);
                results.Add("bodyStyles", bodystyles);
                results.Add("bodyworks", bodyworks);
                results.Add("subsegments", subsegments);
                results.Add("usages", usages);
                results.Add("tractions", tractions);
                results.Add("powers", powers);
                results.Add("fueltypes", fuelTypes);
                results.Add("cabinCFs", cabinCFs);
                results.Add("wheelbases", wheelBases);
                results.Add("axlebases", axleBases);
                results.Add("gears", gears);
                results.Add("doors", doors);
                results.Add("sources", sources);
                results.Add("mcgTotalMkts", mcgTotalMkts);
                results.Add("motorDTs", motorDTs);
                results.Add("aperturesOne", aperturesOne);
                results.Add("aperturesTwo", aperturesTwo);
                results.Add("aperturesThree", aperturesThree);
                results.Add("aperturesFour", aperturesFour);
                results.Add("cjdCompetitives", cjdCompetitive);
                results.Add("engineCapacitys", engineCapacitys);
                results.Add("pbts", pbts);
                results.Add("cabinSDs", cabinSDs);
                results.Add("competitiveCJDs", competitiveCJDs);
                results.Add("configurations", configurations);
                results.Add("altBodysts", altBodysts);
                results.Add("altCategs", altCategs);
                results.Add("altSegms", altSegms);
                results.Add("amgCompSets", amgCompSets);
                results.Add("pbttns", pbttns);
                results.Add("nis", nis);
                results.Add("relevMBs", RelevMBs);
                results.Add("segmentationAux1s", SegmentationAux1s);
                results.Add("ssegms", SSegms);
                results.Add("groups", Groups);
                results.Add("catRules", catRules);
                return new BaseResponse<dynamic>(StatusCodes.Status200OK, results);
                }
                catch (Exception ex)
                {
                    return new BaseResponse<dynamic>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
                }
                finally
                {
                    Dispose();
                }
            }

        public BaseResponse<InternalVersionSegmentation> Create2(InternalVersionSegmentationCreateDto dto)
        {
            try
            {
                var entity = Context.InternalVersionSegmentations.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status400BadRequest, $"La Segmentación ya existe.");
                entity = _mapper.Map<InternalVersionSegmentation>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                var param = new SqlParameter { ParameterName = "@ivsId", Value = entity.Id };
                var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_actualizaVersionClave] @ivsId", param);
                return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<InternalVersionSegmentation>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
