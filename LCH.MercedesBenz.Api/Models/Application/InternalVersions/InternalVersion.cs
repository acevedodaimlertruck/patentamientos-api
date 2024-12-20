using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations; 
using LCH.MercedesBenz.Api.Models.Application.CarModels; 
using LCH.MercedesBenz.Api.Attributes; 

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersions
{
    [Table("InternalVersions")]
    public class InternalVersion : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        //[Required]
        //public Guid BrandId { get; set; }

        //public Brand? Brand { get; set; }

        [StringLength(4)]
        public string? MercedesMarcaId { get; set; }

        [Required]
        public Guid CarModelId { get; set; }

        public CarModel? CarModel { get; set; }

        [StringLength(4)]
        public string? MercedesModeloId { get; set; }

        //[Required]
        //public Guid TerminalId { get; set; }

        //public Terminal? Terminal { get; set; }

        [StringLength(4)]
        public string? MercedesTerminalId { get; set; }

        [StringLength(4)]
        public string? VersionPatentamiento { get; set; }

        [StringLength(4)]
        public string? VersionWs { get; set; }

        [StringLength(4)]
        public string? VersionInterna { get; set; }

        [StringLength(60)]
        public string? DescripcionVerInt { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? UploadDate { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateTo { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateFrom { get; set; } 
    }
}
