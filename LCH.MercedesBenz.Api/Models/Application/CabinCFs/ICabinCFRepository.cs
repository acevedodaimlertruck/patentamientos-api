using LCH.MercedesBenz.Api.Models.Application.CabinCFs.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.CabinCFs
{
    public interface ICabinCFRepository : IBaseRepository<CabinCF>
    {
        BaseResponse<CabinCFDto> GetAll2();
    }
}
