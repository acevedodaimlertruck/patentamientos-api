using LCH.MercedesBenz.Api.Models.Application.Historicals.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Historicals
{
    public interface IHistoricalRepository : IBaseRepository<Historical>
    {
        BaseResponse<HistoricalDto> GetAll2();
    }
}
