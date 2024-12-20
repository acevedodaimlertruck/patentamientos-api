using System.ComponentModel.DataAnnotations.Schema; 
using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Models.Application.CarModels;

namespace LCH.MercedesBenz.Api.Models.Application.WholesaleVersions
{
    [Table("WholesaleVersions")]
    public class WholesaleVersion : BaseEntity
    {
        public int AutoId { get; set; } = 0;


        [Required]
        public Guid CarModelId { get; set; }

        public CarModel? CarModel { get; set; }
        [StringLength(4)]
        public string? MercedesTerminalId { get; set; }
        [StringLength(4)]
        public string? MercedesMarcaId { get; set; }
        [StringLength(4)]
        public string? MercedesModeloId { get; set; }
        [StringLength(20)]
        public string? Version { get; set; }
        [StringLength(60)]
        public string? Description { get; set; }
    }
}
