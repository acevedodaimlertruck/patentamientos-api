using LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.OFMM
{
    public interface IOfmmRepository : IBaseRepository<Ofmm>
    {
        BaseResponse<OfmmDto> GetAll2();

        BaseResponse<Ofmm> Create(OfmmDto dto);

        BaseResponse<IEnumerable<Ofmm>> CreateMultipleOfmms(IEnumerable<OfmmDto> dtos);

        BaseResponse<Ofmm> Update(OfmmDto dto);

        dynamic addJson(dynamic json);
    }
}
