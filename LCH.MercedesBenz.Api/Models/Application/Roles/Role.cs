using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.RolePermissions;
using LCH.MercedesBenz.Api.Models.Application.Users;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Roles
{
    [Table("Roles")]
    public class Role : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<RolePermission> RolePermissions { get; set; } = new HashSet<RolePermission>();

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

    }
}
