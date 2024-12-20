using LCH.MercedesBenz.Api.Models.Application.SpecialSales.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.SpecialSales
{
    public interface ISpecialSaleRepository : IBaseRepository<SpecialSale>
    {
        BaseResponse<SpecialSaleDto> GetAll2();
    }
}
