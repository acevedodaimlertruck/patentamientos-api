using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Wholesales.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Wholesales
{
    public class WholesaleRepository : BaseRepository<Wholesale>, IWholesaleRepository
    {
        private readonly IMapper _mapper;

        public WholesaleRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<WholesaleDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<WholesaleDto>();
                Expression<Func<Wholesale, WholesaleDto>> selector = e => new WholesaleDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    FileId = e.FileId,
                    YearMonth = e.YearMonth,
                    CodBrand = e.CodBrand,
                    Brand = e.Brand,
                    CodModel = e.CodModel,
                    Model = e.Model,
                    CodTrademark = e.CodTrademark,
                    Trademark = e.Trademark,
                    DoorsQty = e.DoorsQty,
                    Engine = e.Engine,
                    MotorType = e.MotorType,
                    FuelType = e.FuelType,
                    Power = e.Power,
                    PowerUnit = e.PowerUnit,
                    VehicleType = e.VehicleType,
                    Traction = e.Traction,
                    GearsQty = e.GearsQty,
                    TransmissionType = e.TransmissionType,
                    AxleQty = e.AxleQty,
                    Weight = e.Weight,
                    LoadCapacity = e.LoadCapacity,
                    Category = e.Category,
                    Origin = e.Origin,
                    InitialStock = e.InitialStock,
                    Import_ProdMonth = e.Import_ProdMonth,
                    Import_ProdAccum = e.Import_ProdAccum,
                    MonthlySale = e.MonthlySale,
                    MonthlyAccum = e.MonthlyAccum,
                    ExportMonthly = e.ExportMonthly,
                    ExportAccum = e.ExportAccum,
                    SavingSystemMonthly = e.SavingSystemMonthly,
                    SavingSystemAccum = e.SavingSystemAccum,
                    FinalStock = e.FinalStock,
                    NoOkStock = e.NoOkStock,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.Wholesales.Select(selector).ToList();
                    return new BaseResponse<WholesaleDto>(StatusCodes.Status200OK, results);
                }
                Func<WholesaleDto, object> orderBy;
                switch (by)
                {
                    case "AutoId":
                        orderBy = e => e.AutoId;
                        break;
                    case "Brand":
                        orderBy = e => e.Brand;
                        break;
                    case "UpdatedAt":
                        orderBy = e => e.UpdatedAt;
                        break;
                    default:
                        orderBy = e => e.CreatedAt;
                        break;
                }
                if (direction == Direction.Ascending)
                {
                    results = Context.Wholesales.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<WholesaleDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.Wholesales.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<WholesaleDto>(StatusCodes.Status200OK, results);
                }
                results = Context.Wholesales.Select(selector).ToList();
                return new BaseResponse<WholesaleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<WholesaleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
