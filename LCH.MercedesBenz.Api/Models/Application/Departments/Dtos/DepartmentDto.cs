using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.Departments.Dtos
{
    public class DepartmentDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? MercedesProvinciaId { get; set; }

        public string? MercedesDepartamentoId { get; set; } 

    }
}
