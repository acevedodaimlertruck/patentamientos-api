using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Factories.Dtos;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.OFMM.Dtos
{
    public class OfmmDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        public string? ZOFMM { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? ValidoHasta { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? ValidoDesde { get; set; }

        public string? FabricaPat { get; set; }

        public string? MarcaPat { get; set; }

        public string? MODELOPAT { get; set; }

        public string? Descripcion1 { get; set; }

        public string? Descripcion2 { get; set; }

        public string? TipoDeTexto { get; set; }

        public string? Terminal { get; set; }

        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public string? VersionPatentamiento { get; set; }

        [Column(TypeName = "char(1)")]
        public string? Origen { get; set; }

        public Guid CarModelId { get; set; }

        public CarModelDto? CarModel { get; set; }

        public Guid FactoryId { get; set; }

        public FactoryDto? Factory { get; set; }

        //public Guid BrandId { get; set; }

        //public Brand? Brand { get; set; }
    }
}
