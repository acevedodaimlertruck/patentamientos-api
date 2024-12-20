using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.Brands.Dtos;
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;
using LCH.MercedesBenz.Api.Models.Application.InternalVersionSegmentations.Dtos;
using LCH.MercedesBenz.Api.Models.Application.Terminals.Dtos;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application.KeyVersions.Dtos
{
    public class KeyVersionDto : BaseDto
    {
        public int AutoId { get; set; } = 0;


        [StringLength(3)]
        public string? MercedesTerminalId { get; set; }

        [StringLength(3)]
        public string? MercedesMarcaId { get; set; }

        [StringLength(3)]
        public string? MercedesModeloId { get; set; }

        [StringLength(4)]
        public string? MercedesVersionClaveId { get; set; }

        [StringLength(5)]
        public string? MercedesVersionInternaId { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateTo { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateFrom { get; set; }

        [StringLength(20)]
        public string? DescriptionShort { get; set; }

        [StringLength(60)]
        public string? DescriptionLong { get; set; }

        [StringLength(5)]
        public string? SegCategory { get; set; }

        [StringLength(5)]
        public string? SegName { get; set; }
    }
}
