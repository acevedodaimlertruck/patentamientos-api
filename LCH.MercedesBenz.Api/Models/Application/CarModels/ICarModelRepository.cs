using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.CarModels
{
    public interface ICarModelRepository : IBaseRepository<CarModel>
    {
        BaseResponse<CarModelDto> GetAll2();

        BaseResponse<CarModelDto> GetNoAssigned();

        BaseResponse<CarModel> Create(CarModelDto dto);

        BaseResponse<CarModel> Update(CarModelDto dto);

        dynamic addJson(dynamic json);
    }
}
