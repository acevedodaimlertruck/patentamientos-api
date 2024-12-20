using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Monthlies.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Monthlies
{
    public class MonthlyRepository : BaseRepository<Monthly>, IMonthlyRepository
    {
        private readonly IMapper _mapper;

        public MonthlyRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<MonthlyDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<MonthlyDto>();
                Expression<Func<Monthly, MonthlyDto>> selector = e => new MonthlyDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    FileId = e.FileId,
                    Source = e.Source,
                    Plate = e.Plate,
                    Motor = e.Motor,
                    Chassis = e.Chassis,
                    FMM_MTM = e.FMM_MTM,
                    Factory_D = e.Factory_D,
                    Brand_D = e.Brand_D,
                    Model_D = e.Model_D,
                    Type_D = e.Type_D,
                    Reg_Date = e.Reg_Date,
                    RegSec = e.RegSec,
                    Desc_Reg = e.Desc_Reg,
                    Mode = e.Mode,
                    Owner = e.Owner,
                    CUIT_PREF = e.CUIT_PREF,
                    Address = e.Address,
                    COD_PRO = e.COD_PRO,
                    DESC_PROV = e.DESC_PROV,
                    COD_DPT = e.COD_DPT,
                    DESC_DPT = e.DESC_DPT,
                    COD_LOC = e.COD_LOC,
                    DESC_LOC = e.DESC_LOC,
                    City = e.City,
                    Zip = e.Zip,
                    Year_Model = e.Year_Model,
                    CodCar = e.CodCar,
                    CountryFA = e.CountryFA,
                    CountryPR = e.CountryPR,
                    Weight = e.Weight,
                    CUIT = e.CUIT,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.Monthlies.Select(selector).ToList();
                    return new BaseResponse<MonthlyDto>(StatusCodes.Status200OK, results);
                }
                Func<MonthlyDto, object> orderBy;
                switch (by)
                {
                    case "AutoId":
                        orderBy = e => e.AutoId;
                        break;
                    case "Source":
                        orderBy = e => e.Source;
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
                    results = Context.Monthlies.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<MonthlyDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.Monthlies.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<MonthlyDto>(StatusCodes.Status200OK, results);
                }
                results = Context.Monthlies.Select(selector).ToList();
                return new BaseResponse<MonthlyDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<MonthlyDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
