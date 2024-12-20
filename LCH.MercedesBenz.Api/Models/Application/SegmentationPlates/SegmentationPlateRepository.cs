using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Patentings.Dtos;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;
using LCH.MercedesBenz.Api.Models.Application.KeyVersions.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Files.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FileTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SegmentationPlates
{
    public class SegmentationPlateRepository : BaseRepository<SegmentationPlate>, ISegmentationPlateRepository
    {
        private readonly IMapper _mapper;

        public SegmentationPlateRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

           public BaseResponse<SegmentationPlateDto> GetAll2()
        {
            try
            {
                var results = Context.SegmentationPlates.Select(i => new SegmentationPlateDto
                {
                    Id = i.Id,
                    PatentingId = i.PatentingId,
                    Patenting = i.Patenting == null ? null : new PatentingDto
                    {
                        Id = i.Patenting.Id,
                        Plate = i.Patenting.Plate,
                        Chasis = i.Patenting.Chasis,
                        Motor = i.Patenting.Motor
                    },
                    OfmmId = i.OfmmId,
                    Ofmm = i.Ofmm == null ? null : new OfmmDto
                    {
                        Id = i.Ofmm.Id,
                        ZOFMM = i.Ofmm.ZOFMM
                    },
                    KeyVersionId = i.KeyVersionId,
                    KeyVersion = i.KeyVersion == null ? null : new KeyVersionDto
                    {
                        Id = i.KeyVersion.Id,
                        MercedesTerminalId = i.KeyVersion.MercedesTerminalId,
                        MercedesMarcaId = i.KeyVersion.MercedesMarcaId,
                        MercedesModeloId = i.KeyVersion.MercedesModeloId,
                        MercedesVersionClaveId = i.KeyVersion.MercedesVersionClaveId,
                        SegCategory = i.KeyVersion.SegCategory,
                        SegName = i.KeyVersion.SegName
                    },
                    MercedesSegmentacionDominioId = i.MercedesSegmentacionDominioId,
                    MercedesSegmentacionDominioNumero = i.MercedesSegmentacionDominioNumero,
                    FileId = i.FileId,
                    File = i.File == null ? null : new FileDto
                    {
                        Id = i.File.Id,
                        Name = i.File.Name,
                        Status = i.File.Status,
                        RecordQuantity = i.File.RecordQuantity,
                        URL = i.File.URL,
                        Date = i.File.Date,
                        Day = i.File.Day,
                        Month = i.File.Month,
                        Year = i.File.Year,
                        FileTypeID = i.File.FileTypeID,
                        FileType = i.File.FileType == null ? null : new FileTypeDto
                        {
                            Id = i.File.FileType.Id,
                            Name = i.File.FileType.Name,
                            Description = i.File.FileType.Description
                        }
                    }
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<SegmentationPlateDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SegmentationPlateDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<dynamic> ProcessSegmentations(string? dateFrom, string? dateTo, Guid? fileId, Guid? patentaId)
        {
            try
            {
                var paramDateFrom = new SqlParameter { ParameterName = "fechaDesde", Value = dateFrom};
                paramDateFrom.Value = paramDateFrom.Value ?? DBNull.Value;
                var paramDateTo = new SqlParameter { ParameterName = "fechaHasta", Value = dateTo };
                paramDateTo.Value = paramDateTo.Value ?? DBNull.Value;
                var paramFileId = new SqlParameter { ParameterName = "idFile", Value = fileId };
                paramFileId.Value = paramFileId.Value ?? DBNull.Value;
                var paramPatentaId = new SqlParameter { ParameterName = "idPatenta", Value = patentaId };
                paramPatentaId.Value = paramPatentaId.Value ?? DBNull.Value;
                var paramIdEjecucion = new SqlParameter("idEjecucion", SqlDbType.VarChar, 50) { Direction = ParameterDirection.Output };
                var query = Context.Database.ExecuteSqlRaw("EXECUTE [dbo].[usp_generaSegmentacion] @fechaDesde, @fechaHasta, @idFile, @idPatenta, @idEjecucion OUTPUT", paramDateFrom, paramDateTo, paramFileId, paramPatentaId, paramIdEjecucion);
                Context.Database.SetCommandTimeout(0);
                var idEjecucion = paramIdEjecucion.Value;
                var results = Context.SegmentationPlates.Count(s => s.MercedesSegmentacionDominioId!.Equals(idEjecucion));

                //Context.SegmentationPlates.Where(s => s.MercedesSegmentacionDominioId!.Equals(idEjecucion)).Select(i => new SegmentationPlateDto
                //{
                //    Id = i.Id,
                //    PatentingId = i.PatentingId,
                //    Patenting = i.Patenting == null ? null : new PatentingDto
                //    {
                //        Id = i.Patenting.Id,
                //        Plate = i.Patenting.Plate,
                //        Chasis = i.Patenting.Chasis,
                //        Motor = i.Patenting.Motor
                //    },
                //    OfmmId = i.OfmmId,
                //    Ofmm = i.Ofmm == null ? null : new OfmmDto
                //    {
                //        Id = i.Ofmm.Id,
                //        ZOFMM = i.Ofmm.ZOFMM
                //    },
                //    KeyVersionId = i.KeyVersionId,
                //    KeyVersion = i.KeyVersion == null ? null : new KeyVersionDto
                //    {
                //        Id = i.KeyVersion.Id,
                //        MercedesTerminalId = i.KeyVersion.MercedesTerminalId,
                //        MercedesMarcaId = i.KeyVersion.MercedesMarcaId,
                //        MercedesModeloId = i.KeyVersion.MercedesModeloId,
                //        MercedesVersionClaveId = i.KeyVersion.MercedesVersionClaveId,
                //        SegCategory = i.KeyVersion.SegCategory,
                //        SegName = i.KeyVersion.SegName
                //    },
                //    MercedesSegmentacionDominioId = i.MercedesSegmentacionDominioId,
                //    MercedesSegmentacionDominioNumero = i.MercedesSegmentacionDominioNumero
                //}).OrderBy(i => i.Id).ToList();
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

        public BaseResponse<SegmentationPlateDto> GetSegmentationsByCategory(string category)
        {
            try
            {
            if (category == "all")
                {
                    var all = Context.SegmentationPlates.Select(i => new SegmentationPlateDto
                    {
                        Id = i.Id,
                        PatentingId = i.PatentingId,
                        Patenting = i.Patenting == null ? null : new PatentingDto
                        {
                            Id = i.Patenting.Id,
                            Plate = i.Patenting.Plate,
                            Chasis = i.Patenting.Chasis,
                            Motor = i.Patenting.Motor
                        },
                        OfmmId = i.OfmmId,
                        Ofmm = i.Ofmm == null ? null : new OfmmDto
                        {
                            Id = i.Ofmm.Id,
                            ZOFMM = i.Ofmm.ZOFMM
                        },
                        KeyVersionId = i.KeyVersionId,
                        KeyVersion = i.KeyVersion == null ? null : new KeyVersionDto
                        {
                            Id = i.KeyVersion.Id,
                            MercedesTerminalId = i.KeyVersion.MercedesTerminalId,
                            MercedesMarcaId = i.KeyVersion.MercedesMarcaId,
                            MercedesModeloId = i.KeyVersion.MercedesModeloId,
                            MercedesVersionClaveId = i.KeyVersion.MercedesVersionClaveId,
                            SegCategory = i.KeyVersion.SegCategory,
                            SegName = i.KeyVersion.SegName
                        },
                        MercedesSegmentacionDominioId = i.MercedesSegmentacionDominioId,
                        MercedesSegmentacionDominioNumero = i.MercedesSegmentacionDominioNumero,
                        FileId = i.FileId,
                        File = i.File == null ? null : new FileDto
                        {
                            Id = i.File.Id,
                            Name = i.File.Name,
                            Status = i.File.Status,
                            RecordQuantity = i.File.RecordQuantity,
                            URL = i.File.URL,
                            Date = i.File.Date,
                            Day = i.File.Day,
                            Month = i.File.Month,
                            Year = i.File.Year,
                            FileTypeID = i.File.FileTypeID,
                            FileType = i.File.FileType == null ? null : new FileTypeDto
                            {
                                Id = i.File.FileType.Id,
                                Name = i.File.FileType.Name,
                                Description = i.File.FileType.Description
                            }
                        }
                    }).OrderBy(i => i.Id).ToList();
                    return new BaseResponse<SegmentationPlateDto>(StatusCodes.Status200OK, all);
                }
                var results = Context.SegmentationPlates.Where(s => s.KeyVersion!.SegCategory!.Equals(category)).Select(i => new SegmentationPlateDto
                {
                    Id = i.Id,
                    PatentingId = i.PatentingId,
                    Patenting = i.Patenting == null ? null : new PatentingDto
                    {
                        Id = i.Patenting.Id,
                        Plate = i.Patenting.Plate,
                        Chasis = i.Patenting.Chasis,
                        Motor = i.Patenting.Motor
                    },
                    OfmmId = i.OfmmId,
                    Ofmm = i.Ofmm == null ? null : new OfmmDto
                    {
                        Id = i.Ofmm.Id,
                        ZOFMM = i.Ofmm.ZOFMM
                    },
                    KeyVersionId = i.KeyVersionId,
                    KeyVersion = i.KeyVersion == null ? null : new KeyVersionDto
                    {
                        Id = i.KeyVersion.Id,
                        MercedesTerminalId = i.KeyVersion.MercedesTerminalId,
                        MercedesMarcaId = i.KeyVersion.MercedesMarcaId,
                        MercedesModeloId = i.KeyVersion.MercedesModeloId,
                        MercedesVersionClaveId = i.KeyVersion.MercedesVersionClaveId,
                        SegCategory = i.KeyVersion.SegCategory,
                        SegName = i.KeyVersion.SegName
                    },
                    MercedesSegmentacionDominioId = i.MercedesSegmentacionDominioId,
                    MercedesSegmentacionDominioNumero = i.MercedesSegmentacionDominioNumero
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<SegmentationPlateDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SegmentationPlateDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<SegmentationPlateDto> GetSegmentationsByFileId(Guid fileId)
        {
            try
            {
                var results = Context.SegmentationPlates.Where(s => s.FileId!.Equals(fileId)).Select(i => new SegmentationPlateDto
                {
                    Id = i.Id,
                    PatentingId = i.PatentingId,
                    Patenting = i.Patenting == null ? null : new PatentingDto
                    {
                        Id = i.Patenting.Id,
                        Plate = i.Patenting.Plate,
                        Chasis = i.Patenting.Chasis,
                        Motor = i.Patenting.Motor
                    },
                    OfmmId = i.OfmmId,
                    Ofmm = i.Ofmm == null ? null : new OfmmDto
                    {
                        Id = i.Ofmm.Id,
                        ZOFMM = i.Ofmm.ZOFMM
                    },
                    KeyVersionId = i.KeyVersionId,
                    KeyVersion = i.KeyVersion == null ? null : new KeyVersionDto
                    {
                        Id = i.KeyVersion.Id,
                        MercedesTerminalId = i.KeyVersion.MercedesTerminalId,
                        MercedesMarcaId = i.KeyVersion.MercedesMarcaId,
                        MercedesModeloId = i.KeyVersion.MercedesModeloId,
                        MercedesVersionClaveId = i.KeyVersion.MercedesVersionClaveId,
                        SegCategory = i.KeyVersion.SegCategory,
                        SegName = i.KeyVersion.SegName
                    },
                    MercedesSegmentacionDominioId = i.MercedesSegmentacionDominioId,
                    MercedesSegmentacionDominioNumero = i.MercedesSegmentacionDominioNumero
                }).OrderBy(i => i.Id).ToList();
                return new BaseResponse<SegmentationPlateDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<SegmentationPlateDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

    }
}
