using LCH.MercedesBenz.Api.Models.Application.Locations.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Locations
{
    public interface ILocationRepository : IBaseRepository<Location>
    {
        BaseResponse<LocationDto> GetAll2();
    }
}
