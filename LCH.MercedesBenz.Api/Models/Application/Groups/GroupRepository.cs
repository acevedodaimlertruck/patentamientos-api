using LCH.MercedesBenz.Api.Models.Application.Groups.Dtos;
using LCH.MercedesBenz.Api.Models.Application.FuelTypes;

namespace LCH.MercedesBenz.Api.Models.Application.Groups
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(
            ApplicationDbContext context) : base(context) 
        { 
        }

        public BaseResponse<GroupDto> GetAll2()
        {
            try
            {
                var results = Context.Groups.Select(i => new GroupDto
                {
                    Id = i.Id,
                    MercedesGroup = i.MercedesGroup,
                    Description = i.Description,
                    SegCategory = i.SegCategory
                }).OrderBy(i => i.MercedesGroup).ToList();
                var noAssigned = results.SingleOrDefault(x => x.Id.Equals(Guid.Parse("00000000-0000-0000-0000-000000000033")));
                if (noAssigned != null)
                    results.Remove(noAssigned);
                return new BaseResponse<GroupDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<GroupDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }
    }
}
