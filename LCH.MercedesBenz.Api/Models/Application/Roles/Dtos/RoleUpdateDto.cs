using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Roles.Dtos
{
    public class RoleUpdateDto
    {
        [StringLength(64)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Description { get; set; }

    }
}
