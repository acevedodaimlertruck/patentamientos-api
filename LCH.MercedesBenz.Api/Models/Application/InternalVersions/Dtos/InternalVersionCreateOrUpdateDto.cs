using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.InternalVersions.Dtos
{
    public class InternalVersionCreateOrUpdateDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        //public Guid BrandId { get; set; }

        public string? MercedesMarcaId { get; set; }

        public Guid CarModelId { get; set; }

        public string? MercedesModeloId { get; set; }

        //public Guid TerminalId { get; set; }

        public string? MercedesTerminalId { get; }

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
