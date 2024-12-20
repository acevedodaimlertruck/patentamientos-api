using LCH.MercedesBenz.Api.Models.Application.Wholesales.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Wholesales
{
    public interface IWholesaleRepository : IBaseRepository<Wholesale>
    {
        BaseResponse<WholesaleDto> GetAll(string? orderBy = null, Direction direction = Direction.None);
    }
}
