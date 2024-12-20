using LCH.MercedesBenz.Api.Models.Application.Owners.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Owners
{
    public interface IOwnerRepository : IBaseRepository<Owner>
    {
        BaseResponse<OwnerDto> GetAll2();

        BaseResponse<Owner> Create(OwnerDto dto);

        BaseResponse<Owner> Update(OwnerDto dto);

    }
}
