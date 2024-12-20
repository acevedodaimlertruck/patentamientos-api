using LCH.MercedesBenz.Api.Models.Application.RegSecs.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.RegSecs
{
    public interface IRegSecRepository : IBaseRepository<RegSec>
    {
        BaseResponse<RegSecDto> GetAll2();

        BaseResponse<RegSec> UploadFile(RegSecUpload formUpload);

        BaseResponse<RegSec> Create(RegSecDto dto);

        BaseResponse<RegSec> Update(RegSecDto dto);
    }
}
