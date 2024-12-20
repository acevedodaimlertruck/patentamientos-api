using LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.MCGTotalMkts
{
    public interface IMCGTotalMktRepository : IBaseRepository<MCGTotalMkt>
    {
        BaseResponse<MCGTotalMktDto> GetAll2();
    }
}
