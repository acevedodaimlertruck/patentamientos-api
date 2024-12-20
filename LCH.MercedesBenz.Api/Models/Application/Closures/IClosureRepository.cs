using LCH.MercedesBenz.Api.Models.Application.Closures.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Closures
{
    public interface IClosureRepository : IBaseRepository<Closure>
    {
        BaseResponse<ClosureDto> GetAll2();

        BaseResponse<Closure> Create(ClosureDto dto);

        dynamic addJson(dynamic json);
    }
}
