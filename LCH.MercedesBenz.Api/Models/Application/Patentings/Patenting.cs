using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.Closures;
using LCH.MercedesBenz.Api.Models.Application.Departments;
using LCH.MercedesBenz.Api.Models.Application.Factories;
using LCH.MercedesBenz.Api.Models.Application.Locations;
using LCH.MercedesBenz.Api.Models.Application.Owners;
using LCH.MercedesBenz.Api.Models.Application.Provinces;
using LCH.MercedesBenz.Api.Models.Application.RegSecs;
using LCH.MercedesBenz.Api.Models.Application.RulePatentings;
using LCH.MercedesBenz.Api.Models.Application.SegmentationPlates;
using LCH.MercedesBenz.Api.Models.Application.StatePatentas;
using LCH.MercedesBenz.Api.Models.Application.VehicleTypes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Patentings
{
    [Table("Patentings")]
    public class Patenting : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid OwnerId { get; set; }

        [JsonIgnore]
        public virtual Owner? Owner { get; set; }

        [Required]
        public Guid FactoryId { get; set; }

        [JsonIgnore]
        public virtual Factory? Factory { get; set; }

        [Required]
        public Guid CarModelId { get; set; }

        [JsonIgnore]
        public virtual CarModel? CarModel { get; set; }

        [Required]
        public Guid ClosureId { get; set; }

        public virtual Closure? Closure { get; set; }

        [StringLength(64)]
        public string Plate { get; set; } = string.Empty;

        [StringLength(64)]
        public string Motor { get; set; } = string.Empty;

        [StringLength(64)]
        public string Chasis { get; set; } = string.Empty;

        [StringLength(50)]
        public string OFMM { get; set; } = string.Empty;

        [StringLength(1)]
        public string Origen { get; set; } = string.Empty;

        [StringLength(9)]
        public string FMM_MTM { get; set; } = string.Empty;

        [StringLength(8)]
        public string? CalDay { get; set; } = string.Empty;

        [StringLength(6)]
        public string? CalMonth { get; set; } = string.Empty;

        [StringLength(4)]
        public string CalYear { get; set; } = string.Empty;

        [StringLength(20)]
        public string NroRegistro { get; set; } = string.Empty;

        [StringLength(150)]
        public string Direccion { get; set; } = string.Empty;

        [StringLength(20)]
        public string CodigoPostal { get; set; } = string.Empty;

        [StringLength(20)]
        public string Anio { get; set; } = string.Empty;

        [StringLength(20)]
        public string Auto { get; set; } = string.Empty;

        [StringLength(20)]
        public string PaisFabrica { get; set; } = string.Empty;

        [StringLength(20)]
        public string PaisProced { get; set; } = string.Empty;

        [StringLength(20)]
        public string Peso { get; set; } = string.Empty;

        [Required]
        public int CantPatentamiento { get; set; } = 1;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? FechaCarga { get; set; }

        [StringLength(10)]
        public string OFMM_ERROR { get; set; } = string.Empty;

        public bool Es_Duplicado { get; set; } = false;

        [Required]
        public Guid RegSecId { get; set; }

        [JsonIgnore]
        public virtual RegSec? RegSec { get; set; }

        [Required]
        public Guid ProvinceId { get; set; }

        [JsonIgnore]
        public virtual Province? Province { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }

        [JsonIgnore]
        public virtual Department? Department { get; set; }

        [Required]
        public Guid LocationId { get; set; }

        [JsonIgnore]
        public virtual Location? Location { get; set; }

        //[Required]
        //public Guid BrandId { get; set; }

        //[JsonIgnore]
        //public virtual Brand? Brand { get; set; }

        [Required]
        public Guid StatePatentaId { get; set; }

        [JsonIgnore]
        public virtual StatePatenta? StatePatenta { get; set; }

        [Required]
        public Guid VehicleTypeId { get; set; }

        [JsonIgnore]
        public virtual VehicleType? VehicleType { get; set; }

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public virtual File? File { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechInsc { get; set; }

        [StringLength(6)]
        public string FabricaPat { get; set; } = string.Empty;

        [StringLength(6)]
        public string MarcaPat { get; set; } = string.Empty;

        [StringLength(6)]
        public string ModeloPat { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Fabrica_D { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Marca_D { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Modelo_D { get; set; } = string.Empty;

        [StringLength(512)]
        public string? Tipo_D { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<RulePatenting> RulePatentings { get; set; } = new HashSet<RulePatenting>();

        [JsonIgnore]
        public virtual SegmentationPlate? SegmentationPlate { get; set; }
    }
}
