using LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.EstimatedTurnovers
{
    public interface IEstimatedTurnoverRepository : IBaseRepository<EstimatedTurnover>
    {
        BaseResponse<EstimatedTurnoverDto> GetAll2();
    }
}
