using LCH.MercedesBenz.Api.Models.Application.OdsWholesales.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OdsWholesales
{
    public interface IOdsWholesaleRepository : IBaseRepository<OdsWholesale>
    {
        BaseResponse<OdsWholesaleDto> GetAll2();

        BaseResponse<OdsWholesaleDto> GetByFileId(Guid fileId);

        BaseResponse<OdsWholesale> SaveWholesale(OdsWholesaleDto odsWholesaleDto);

        BaseResponse<OdsWholesale> Create(OdsWholesaleDto dto);

        BaseResponse<OdsWholesale> Update(OdsWholesaleDto dto);
    }
}
