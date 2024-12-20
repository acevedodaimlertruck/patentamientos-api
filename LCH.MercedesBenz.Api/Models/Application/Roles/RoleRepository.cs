using System.Linq.Expressions;
using AutoMapper;
using LCH.MercedesBenz.Api.Models.Application.Roles.Dtos;
using LCH.MercedesBenz.Api.Services.HttpContext;

namespace LCH.MercedesBenz.Api.Models.Application.Roles
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private readonly IMapper _mapper;
        private readonly IHttpContextService _httpContextService;

        public RoleRepository(
            ApplicationDbContext context,
            IMapper mapper,
            IHttpContextService httpContextService) : base(context)
        {
            _mapper = mapper;
            _httpContextService = httpContextService;
        }

        public BaseResponse<RoleDto> GetAll(string? by = null, Direction direction = Direction.None)
        {
            try
            {
                var results = new List<RoleDto>();
                Expression<Func<Role, RoleDto>> selector = e => new RoleDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    Name = e.Name,
                    Description = e.Description,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                };
                if (string.IsNullOrEmpty(by))
                {
                    results = Context.Roles.Select(selector).ToList();
                    return new BaseResponse<RoleDto>(StatusCodes.Status200OK, results);
                }
                Func<RoleDto, object> orderBy;
                switch (by)
                {
                    case "AutoId":
                        orderBy = e => e.AutoId;
                        break;
                    case "Name":
                        orderBy = e => e.Name;
                        break;
                    case "UpdatedAt":
                        orderBy = e => e.UpdatedAt;
                        break;
                    default:
                        orderBy = e => e.CreatedAt;
                        break;
                }
                if (direction == Direction.Ascending)
                {
                    results = Context.Roles.Select(selector).OrderBy(orderBy).ToList();
                    return new BaseResponse<RoleDto>(StatusCodes.Status200OK, results);
                }
                if (direction == Direction.Descending)
                {
                    results = Context.Roles.Select(selector).OrderByDescending(orderBy).ToList();
                    return new BaseResponse<RoleDto>(StatusCodes.Status200OK, results);
                }
                results = Context.Roles.Select(selector).ToList();
                return new BaseResponse<RoleDto>(StatusCodes.Status200OK, results);
            }
            catch (Exception ex)
            {
                return new BaseResponse<RoleDto>(StatusCodes.Status500InternalServerError, ex.Message, ex.StackTrace);
            }
            finally
            {
                Dispose();
            }
        }

        public BaseResponse<RoleDto> GetAll3()
        {
            var roleId = _httpContextService.GetRoleId();
            var user = _httpContextService.GetUserId();
            if (string.IsNullOrEmpty(roleId))
                return new BaseResponse<RoleDto>(StatusCodes.Status400BadRequest, "Token inválido.");

            Expression<Func<Role, bool>> where = e => true;
            var saId = Guid.Parse("00000000-0000-0000-0000-000000000001");
            var agId = Guid.Parse("00000000-0000-0000-0000-000000000002");
            var aeId = Guid.Parse("00000000-0000-0000-0000-000000000003");
            switch (roleId)
            {
                case "00000000-0000-0000-0000-000000000001":
                    break;
                case "00000000-0000-0000-0000-000000000002":
                    where = e => !e.Id.Equals(saId);
                    break;
                case "00000000-0000-0000-0000-000000000003":
                    where = e => e.Id.Equals(aeId);
                    break;
                case "00000000-0000-0000-0000-000000000004":
                    where = e => !e.Id.Equals(agId) && !e.Id.Equals(saId);
                    break;
                case "00000000-0000-0000-0000-000000000005":
                    where = e => !e.Id.Equals(agId) && !e.Id.Equals(saId);
                    break;
            }

            var results = Context.Roles
                .Where(where)
                .Select(e => new RoleDto
                {
                    Id = e.Id,
                    AutoId = e.AutoId,
                    Name = e.Name,
                    Description = e.Description,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                }).OrderBy(e => e.Name).ToList();
            return new BaseResponse<RoleDto>(StatusCodes.Status200OK, results);
        }
    }
}
