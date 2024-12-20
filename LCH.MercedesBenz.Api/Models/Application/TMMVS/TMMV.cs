using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.Terminals;

namespace LCH.MercedesBenz.Api.Models.Application.TMMVS
{
    [Table("Tmmv")]
    public class TMMV : BaseEntity
    {
        public int AutoId { get; set; } = 0;
        [Required]
        public Guid CarModelId { get; set; }
        public CarModel? CarModel { get; set; }
        [StringLength(4)]
        public string? MercedesTerminalId { get; set; }
        [StringLength(60)]
        public string? DescripcionTerminal { get; set; }
        [StringLength(4)]
        public string? MercedesMarcaId { get; set; }
        [StringLength(60)]
        public string? DescripcionMarca { get; set; }
        [StringLength(4)]
        public string? MercedesModeloId { get; set; }
        [StringLength(60)]
        public string? DescripcionModelo { get; set; }
        [StringLength(4)]
        public string? VersionPatentamiento { get; set; }
        [StringLength(60)]
        public string? DescripcionVerPat { get; set; }

        [StringLength(4)]
        public string? VersionWs { get; set; }
        [StringLength(60)]
        public string? DescripcionVerWs { get; set; }
        [StringLength(4)]
        public string? VersionInterna { get; set; }
        [StringLength(60)]
        public string? DescripcionVerInt { get; set; } 
    }
}