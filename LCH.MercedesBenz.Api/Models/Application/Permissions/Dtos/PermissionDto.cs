using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Permissions.Dtos
{
    public class PermissionDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

        public int Ordering { get; set; }

        public bool Granted { get; set; } = false;
    }
}
