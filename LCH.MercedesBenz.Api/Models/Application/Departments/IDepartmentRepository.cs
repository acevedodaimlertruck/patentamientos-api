using LCH.MercedesBenz.Api.Models.Application.Departments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Departments
{
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        BaseResponse<DepartmentDto> GetAll2();
    }
}
