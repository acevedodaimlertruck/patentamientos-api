using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.Permissions;
using LCH.MercedesBenz.Api.Models.Application.Roles;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.RolePermissions
{
    [Table("RolePermissions")]
    public class RolePermission : BaseEntity
    {
        [Required]
        public Guid RoleId { get; set; }

        [JsonIgnore]
        public virtual Role? Role { get; set; }

        [Required]
        public Guid PermissionId { get; set; }

        [JsonIgnore]
        public virtual Permission? Permission { get; set; }
    }
}