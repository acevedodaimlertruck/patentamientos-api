using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.Factories;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.OFMM
{
    [Table("Ofmm")]
    public class Ofmm : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [StringLength(512)]
        public string? ZOFMM { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? ValidoHasta { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? ValidoDesde { get; set; }

        [StringLength(512)]
        public string? FabricaPat { get; set; }

        [StringLength(512)]
        public string? MarcaPat { get; set; }

        [StringLength(512)]
        public string? MODELOPAT { get; set; }

        [StringLength(512)]
        public string? Descripcion1 { get; set; }

        [StringLength(512)]
        public string? Descripcion2 { get; set; }

        [StringLength(512)]
        public string? TipoDeTexto { get; set; }

        [StringLength(512)]
        public string? Terminal { get; set; }

        [StringLength(512)]
        public string? Marca { get; set; }

        [StringLength(512)]
        public string? Modelo { get; set; }

        [StringLength(512)]
        public string? VersionPatentamiento { get; set; }

        [Column(TypeName = "char(1)")]
        [StringLength(1)]
        public string? Origen { get; set; }

        [Required]
        public Guid CarModelId { get; set; }

        public CarModel? CarModel { get; set; }

        [Required]
        public Guid FactoryId { get; set; }

        public Factory? Factory { get; set; }

        //[Required]
        //public Guid BrandId { get; set; }

        //public Brand? Brand { get; set; }

        [JsonIgnore]
        public virtual ICollection<SegmentationPlate> SegmentationPlates { get; set; } = new HashSet<SegmentationPlate>();
    }
}
