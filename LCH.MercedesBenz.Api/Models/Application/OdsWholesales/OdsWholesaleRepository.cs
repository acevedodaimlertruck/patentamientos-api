using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Categories.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Grados.Dtos;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales.Dtos;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LCH.MercedesBenz.Api.Models.Application.OdsWholesales
{
    public class OdsWholesaleRepository : BaseRepository<OdsWholesale>, IOdsWholesaleRepository
    {
        private readonly IMapper _mapper;

        public OdsWholesaleRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

           public BaseResponse<OdsWholesaleDto> GetAll2()
        {
            try
            {
                var results = Context.OdsWholesales.Select(i => new OdsWholesaleDto
                {
                    Id = i.Id,
                    YearMonth = i.YearMonth,
                    CodBrand = i.CodBrand,
                    Brand = i.Brand,
                    CodModel = i.CodModel,
                    Model = i.Model,
                    CodTrademark = i.CodTrademark,
                    Trademark = i.Trademark,
                    GradoId = i.GradoId,
                    Grado = i.Grado == null ? null : new GradoDto
                    {
                        Id = i.Grado.Id,
                        MarcaWs = i.Grado.MarcaWs,
                        ModeloWs = i.Grado.ModeloWs,
                        Grade = i.Grado.Grade,
                        DateTo = i.Grado.DateTo,
                        DateFrom = i.Grado.DateFrom,
                        MercedesTerminalId = i.Grado.MercedesTerminalId,
                        MercedesMarcaId = i.Grado.MercedesMarcaId,
                        MercedesModeloId = i.Grado.MercedesModeloId,
                        CarModelId = i.Grado.CarModelId,
                        CarModel = i.Grado.CarModel == null ? null : new CarModelDto
                        {
                            Id = i.Grado.CarModel.Id,
                            Name = i.Grado.CarModel.Name,
                            Description = i.Grado.CarModel.Description,
                            MercedesTerminalId = i.Grado.CarModel.MercedesTerminalId,
                            MercedesMarcaId = i.Grado.CarModel.MercedesMarcaId,
                            MercedesModeloId = i.Grado.CarModel.MercedesModeloId,
                            BrandId = i.Grado.CarModel.BrandId,
                            Brand = i.Grado.CarModel.Brand == null ? null : new BrandDto
                            {
                                Id = i.Grado.CarModel.Brand.Id,
                                Name = i.Grado.CarModel.Brand.Name,
                                Description = i.Grado.CarModel.Brand.Description,
                                MercedesTerminalId = i.Grado.CarModel.Brand.MercedesTerminalId,
                                MercedesMarcaId = i.Grado.CarModel.Brand.MercedesMarcaId,
                                TerminalId = i.Grado.CarModel.Brand.TerminalId,
                                Terminal = i.Grado.CarModel.Brand.Terminal == null ? null : new TerminalDto
                                {
                                    Id = i.Grado.CarModel.Brand.Terminal.Id,
                                    Name = i.Grado.CarModel.Brand.Terminal.Name,
                                    Description = i.Grado.CarModel.Brand.Terminal.Description,
                                    MercedesTerminalId = i.Grado.CarModel.Brand.Terminal.MercedesTerminalId
                                }
                            }
                        },
                    },
                    DoorsQty = i.DoorsQty,
                    Engine = i.Engine,
                    MotorType = i.MotorType,
                    FuelType = i.FuelType,
                    Power = i.Power,
                    PowerUnit = i.PowerUnit,
                    MercedesVehicleType = i.MercedesVehicleType,
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description
                    },
                    Traction = i.Traction,
                    GearsQty = i.GearsQty,
                    TransmissionType = i.TransmissionType,
                    AxleQty = i.AxleQty,
                    Weight = i.Weight,
                    LoadCapacity = i.LoadCapacity,
                    MercedesCategory = i.MercedesCategory,
                    CategoryId = i.CategoryId,
                    Category = i.Category == null ? null : new CategoryDto
                    {
                        Id = i.Category.Id,
                        SegCategory = i.Category.SegCategory,
                        Description = i.Category.Description
                    },
                    Origin = i.Origin,
                    InitialStock = i.InitialStock,
                    Import_ProdMonth = i.Import_ProdMonth,
                    Import_ProdAccum = i.Import_ProdAccum,
                    MonthlySale = i.MonthlySale,
                    MonthlyAccum = i.MonthlyAccum,
                    ExportMonthly = i.ExportMonthly,
                    ExportAccum = i.ExportAccum,
                    SavingSystemMonthly = i.SavingSystemMonthly,
                    SavingSystemAccum = i.SavingSystemAccum,
                    FinalStock = i.FinalStock,
                    NoOkStock = i.NoOkStock,
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new FileDto
                    {
                        Id = i.FileId,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    ErrorName = string.Join(", ", Context.RuleOdsWholesales
                                         .Where(rp => rp.OdsWholesaleId == i.Id)
                                         .Select(rp => rp.Rule!.Name)),
                    Errores = string.Join(", ", Context.RuleOdsWholesales
                                         .Where(rp => rp.OdsWholesaleId == i.Id)
                                         .Select(rp => rp.Rule!.Code)),
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<OdsWholesaleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<OdsWholesaleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<OdsWholesaleDto> GetByFileId(Guid fileId)
        {
            try
            {
                var results = Context.OdsWholesales.Where(s => s.FileId.Equals(fileId)).Select(i => new OdsWholesaleDto
                {
                    Id = i.Id,
                    YearMonth = i.YearMonth,
                    CodBrand = i.CodBrand,
                    Brand = i.Brand,
                    CodModel = i.CodModel,
                    Model = i.Model,
                    CodTrademark = i.CodTrademark,
                    Trademark = i.Trademark,
                    GradoId = i.GradoId,
                    Grado = i.Grado == null ? null : new GradoDto
                    {
                        Id = i.Grado.Id,
                        MarcaWs = i.Grado.MarcaWs,
                        ModeloWs = i.Grado.ModeloWs,
                        Grade = i.Grado.Grade,
                        DateTo = i.Grado.DateTo,
                        DateFrom = i.Grado.DateFrom,
                        MercedesTerminalId = i.Grado.MercedesTerminalId,
                        MercedesMarcaId = i.Grado.MercedesMarcaId,
                        MercedesModeloId = i.Grado.MercedesModeloId,
                        CarModelId = i.Grado.CarModelId,
                        CarModel = i.Grado.CarModel == null ? null : new CarModelDto
                        {
                            Id = i.Grado.CarModel.Id,
                            Name = i.Grado.CarModel.Name,
                            Description = i.Grado.CarModel.Description,
                            MercedesTerminalId = i.Grado.CarModel.MercedesTerminalId,
                            MercedesMarcaId = i.Grado.CarModel.MercedesMarcaId,
                            MercedesModeloId = i.Grado.CarModel.MercedesModeloId,
                            BrandId = i.Grado.CarModel.BrandId,
                            Brand = i.Grado.CarModel.Brand == null ? null : new BrandDto
                            {
                                Id = i.Grado.CarModel.Brand.Id,
                                Name = i.Grado.CarModel.Brand.Name,
                                Description = i.Grado.CarModel.Brand.Description,
                                MercedesTerminalId = i.Grado.CarModel.Brand.MercedesTerminalId,
                                MercedesMarcaId = i.Grado.CarModel.Brand.MercedesMarcaId,
                                TerminalId = i.Grado.CarModel.Brand.TerminalId,
                                Terminal = i.Grado.CarModel.Brand.Terminal == null ? null : new TerminalDto
                                {
                                    Id = i.Grado.CarModel.Brand.Terminal.Id,
                                    Name = i.Grado.CarModel.Brand.Terminal.Name,
                                    Description = i.Grado.CarModel.Brand.Terminal.Description,
                                    MercedesTerminalId = i.Grado.CarModel.Brand.Terminal.MercedesTerminalId
                                }
                            }
                        },
                    },
                    DoorsQty = i.DoorsQty,
                    Engine = i.Engine,
                    MotorType = i.MotorType,
                    FuelType = i.FuelType,
                    Power = i.Power,
                    PowerUnit = i.PowerUnit,
                    MercedesVehicleType = i.MercedesVehicleType,
                    VehicleTypeId = i.VehicleTypeId,
                    VehicleType = i.VehicleType == null ? null : new VehicleTypeDto
                    {
                        Id = i.VehicleType.Id,
                        Name = i.VehicleType.Name,
                        Description = i.VehicleType.Description
                    },
                    Traction = i.Traction,
                    GearsQty = i.GearsQty,
                    TransmissionType = i.TransmissionType,
                    AxleQty = i.AxleQty,
                    Weight = i.Weight,
                    LoadCapacity = i.LoadCapacity,
                    MercedesCategory = i.MercedesCategory,
                    CategoryId = i.CategoryId,
                    Category = i.Category == null ? null : new CategoryDto
                    {
                        Id = i.Category.Id,
                        SegCategory = i.Category.SegCategory,
                        Description = i.Category.Description
                    },
                    Origin = i.Origin,
                    InitialStock = i.InitialStock,
                    Import_ProdMonth = i.Import_ProdMonth,
                    Import_ProdAccum = i.Import_ProdAccum,
                    MonthlySale = i.MonthlySale,
                    MonthlyAccum = i.MonthlyAccum,
                    ExportMonthly = i.ExportMonthly,
                    ExportAccum = i.ExportAccum,
                    SavingSystemMonthly = i.SavingSystemMonthly,
                    SavingSystemAccum = i.SavingSystemAccum,
                    FinalStock = i.FinalStock,
                    NoOkStock = i.NoOkStock,
                    StatePatentaId = i.StatePatentaId,
                    StatePatenta = i.StatePatenta == null ? null : new StatePatentaDto
                    {
                        Id = i.StatePatenta.Id,
                        Name = i.StatePatenta.Name,
                        Description = i.StatePatenta.Description
                    },
                    FileId = i.FileId,
                    File = i.File == null ? null : new FileDto
                    {
                        Id = i.FileId,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID
                    },
                    ErrorName = string.Join(", ", Context.RuleOdsWholesales
                                         .Where(rp => rp.OdsWholesaleId == i.Id)
                                         .Select(rp => rp.Rule!.Name)),
                    Errores = string.Join(", ", Context.RuleOdsWholesales
                                         .Where(rp => rp.OdsWholesaleId == i.Id)
                                         .Select(rp => rp.Rule!.Code)),
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<OdsWholesaleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<OdsWholesaleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<OdsWholesale> Create(OdsWholesaleDto dto)
        {
            try
            {
                var entity = Context.OdsWholesales.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity != null)
                    return new BaseResponse<OdsWholesale>(StatusCodes.Status400BadRequest, $"Patenting Wholesale ya existe.");
                entity = _mapper.Map<OdsWholesale>(dto);
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                InsertAndSave(entity);
                return new BaseResponse<OdsWholesale>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<OdsWholesale>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<OdsWholesale> SaveWholesale(OdsWholesaleDto odsWholesaleDto)
        {
            try
            {
                if (odsWholesaleDto.Id == Guid.Empty)
                    return new BaseResponse<OdsWholesale>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.OdsWholesales.SingleOrDefault(p => p.Id.Equals(odsWholesaleDto.Id));
                if (entity == null)
                    return new BaseResponse<OdsWholesale>(StatusCodes.Status400BadRequest, $"Wholesale no encontrado (Id={odsWholesaleDto.Id}).");
                _mapper.Map(odsWholesaleDto, entity);
                UpdateAndSave(entity);
                var paramFileID = new SqlParameter { ParameterName = "FileID", Value = entity.FileId };
                var paramWsID = new SqlParameter { ParameterName = "wsID", Value = entity.Id };
                var result = Context.Database.ExecuteSqlRaw("EXEC [dbo].[usp_executeGeneralRuleWS] @FileID, @wsID", paramFileID, paramWsID);
                return new BaseResponse<OdsWholesale>(StatusCodes.Status200OK, entity);
            }
            catch (Exception ex)
            {
                return new BaseResponse<OdsWholesale>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<OdsWholesale> Update(OdsWholesaleDto dto)
        {
            try
            {
                if (dto.Id == Guid.Empty)
                    return new BaseResponse<OdsWholesale>(StatusCodes.Status400BadRequest, $"El campo \"id\" es requerido.");
                var entity = Context.OdsWholesales.SingleOrDefault(p => p.Id.Equals(dto.Id));
                if (entity == null)
                    return new BaseResponse<OdsWholesale>(StatusCodes.Status400BadRequest, $"Id de Patenting Wholesale no encontrado.");
                _mapper.Map(dto, entity);
                UpdateAndSave(entity);
                return new BaseResponse<OdsWholesale>(StatusCodes.Status200OK, entity);
            }
            catch (Exception e)
            {
                return new BaseResponse<OdsWholesale>(StatusCodes.Status500InternalServerError, e.Message, e.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
