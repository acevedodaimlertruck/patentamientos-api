using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos
{
    public class InternalVersionDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        //public Guid BrandId { get; set; }

        //public BrandDto? Brand { get; set; }

        public string? MercedesMarcaId { get; set; }

        public Guid CarModelId { get; set; }

        public CarModelDto? CarModel { get; set; }

        public string? MercedesModeloId { get; set; }

        //public Guid TerminalId { get; set; }

        //public TerminalDto? Terminal { get; set; }

        public string? MercedesTerminalId { get; set; }

        public string? VersionPatentamiento { get; set; }

        public string? VersionWs { get; set; }

        public string? VersionInterna { get; set; }

        public string? DescripcionVerInt { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? UploadDate { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateTo { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateFrom { get; set; }
    }
}
