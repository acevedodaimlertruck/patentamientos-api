using LCH.MercedesBenz.Api.Models.Application.TMMVS.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.TMMVS
{
    public interface ITMMVRepository : IBaseRepository<TMMV>
    {
        BaseResponse<TMMVDto> GetAll2();

        BaseResponse<TMMV> Create(TMMVDto dto);

        BaseResponse<TMMV> Update(TMMVDto dto);
        BaseResponse<TMMVDto> GetVerPats(Guid carModelId);
        dynamic addJson(dynamic json);
    }
}
