using LCH.MercedesBenz.Api.Models.Application.Patentings;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.Departments
{
    [Table("Departments")]
    public class Department : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(64)]
        public string Name { get; set; } = string.Empty;

        [StringLength(256)]
        public string? Description { get; set; }

        [StringLength(256)]
        public string? MercedesProvinciaId { get; set; }

        [StringLength(256)]
        public string? MercedesDepartamentoId { get; set; }

        [JsonIgnore]
        public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();
    }
}
