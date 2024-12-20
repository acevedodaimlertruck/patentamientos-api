using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Closures.Dtos
{
    public class ClosureDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? FechaCorte { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? FechaCreacion { get; set; }

        public string? HoraCreacion { get; set; }

        public bool EsUltimo { get; set; } = false;
    }
}
