using LCH.MercedesBenz.Api.Models.Application.CabinSDs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.CabinSDs
{
    public interface ICabinSDRepository : IBaseRepository<CabinSD>
    {
        BaseResponse<CabinSDDto> GetAll2();
    }
}
