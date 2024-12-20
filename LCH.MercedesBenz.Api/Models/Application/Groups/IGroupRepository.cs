using LCH.MercedesBenz.Api.Models.Application.Groups.Dtos;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Groups
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        BaseResponse<GroupDto> GetAll2();
    }
}
