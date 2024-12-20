using LCH.MercedesBenz.Api.Models.Application.VehicleTypes.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.VehicleTypes
{
    public interface IVehicleTypeRepository : IBaseRepository<VehicleType>
    {
        BaseResponse<VehicleTypeDto> GetAll2();

        BaseResponse<VehicleType> Create(VehicleTypeDto dto);

        BaseResponse<VehicleType> Update(VehicleTypeDto dto);
    }
}
