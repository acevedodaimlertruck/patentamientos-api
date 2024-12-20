using LCH.MercedesBenz.Api.Models.Application.Permissions.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Roles.Dtos
{
    public class RoleDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        public List<PermissionDto> Permissions { get; set; } = new List<PermissionDto>();

        public bool IsAllPermissionsChecked { get; set; } = false;
    }
}
