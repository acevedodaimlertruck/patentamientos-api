using LCH.MercedesBenz.Api.Models.Application.Departments.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.Departments
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<DepartmentDto> GetAll2()
        {
            try
            {
                var results = Context.Departments.Select(i => new DepartmentDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    MercedesProvinciaId = i.MercedesProvinciaId,
                    MercedesDepartamentoId = i.MercedesDepartamentoId
                }).OrderBy(i => i.Name).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<DepartmentDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<DepartmentDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
