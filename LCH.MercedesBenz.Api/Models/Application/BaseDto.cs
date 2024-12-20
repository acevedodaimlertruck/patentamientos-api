using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application
{
    public class BaseDto
    {
        public Guid? Id { get; set; } = Guid.NewGuid();

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? CreatedAt { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? UpdatedAt { get; set; }
    }
}
