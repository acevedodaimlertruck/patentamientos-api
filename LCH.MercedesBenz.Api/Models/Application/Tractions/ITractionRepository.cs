using LCH.MercedesBenz.Api.Models.Application.Tractions.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Tractions
{
    public interface ITractionRepository : IBaseRepository<Traction>
    {
        BaseResponse<TractionDto> GetAll2();
    }
}
