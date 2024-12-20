
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Attributes; 
using Newtonsoft.Json;

namespace LCH.MercedesBenz.Api.Models.Application.Cat_InternalVersions.Dtos
{
    public class Cat_InternalVersionDto : BaseDto
    {
        public int AutoId { get; set; } = 0;
        public string? MercedesMarcaId { get; set; }
        public Guid CarModelId { get; set; }
        public CarModelDto? CarModel { get; set; }
        public string? MercedesModeloId { get; set; }
        public string? MercedesTerminalId { get; set; }
        public string? Version { get; set; }
        public string? Description { get; set; }
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateTo { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateFrom { get; set; }
    }
}
