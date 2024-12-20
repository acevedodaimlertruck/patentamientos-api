using LCH.MercedesBenz.Api.Models.Application.ApertureFours.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.ApertureFours
{
    public interface IApertureFourRepository : IBaseRepository<ApertureFour>
    {
        BaseResponse<ApertureFourDto> GetAll2();
    }
}
