using LCH.MercedesBenz.Api.Models.Application.Dailies.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Dailies
{
    public interface IDailyRepository : IBaseRepository<Daily>
    {
        BaseResponse<DailyDto> GetAll(string? orderBy = null, Direction direction = Direction.None);
    }
}
