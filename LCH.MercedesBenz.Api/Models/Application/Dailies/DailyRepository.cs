using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Dailies.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Dailies
{
    public class DailyRepository : BaseRepository<Daily>, IDailyRepository
    {
        private readonly IMapper _mapper;

        public DailyRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public BaseResponse<DailyDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<DailyDto>();
                Expression<Func<Daily, DailyDto>> selector = e => new DailyDto
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
                    Desc_Prov = e.Desc_Prov,
                    Taxi = e.Taxi,
                    CUIT = e.CUIT,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.Dailies.Select(selector).ToList();
                    return new BaseResponse<DailyDto>(StatusCodes.Status200OK, results);
                }
                Func<DailyDto, object> orderBy;
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
                    results = Context.Dailies.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<DailyDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.Dailies.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<DailyDto>(StatusCodes.Status200OK, results);
                }
                results = Context.Dailies.Select(selector).ToList();
                return new BaseResponse<DailyDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<DailyDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
