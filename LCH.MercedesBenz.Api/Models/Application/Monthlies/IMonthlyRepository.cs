using LCH.MercedesBenz.Api.Models.Application.Monthlies.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Monthlies
{
    public interface IMonthlyRepository : IBaseRepository<Monthly>
    {
        BaseResponse<MonthlyDto> GetAll(string? orderBy = null, Direction direction = Direction.None);
    }
}
