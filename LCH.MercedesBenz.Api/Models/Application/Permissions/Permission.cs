using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LCH.MercedesBenz.Api.Models.Application.RolePermissions;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Permissions
{
    [Table("Permissions")]
    public class Permission : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        public int Ordering { get; set; }

        [JsonIgnore]
        public virtual ICollection<RolePermission> RolePermissions { get; set; } = new HashSet<RolePermission>();
    }
}
