using LCH.MercedesBenz.Api.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LCH.MercedesBenz.Api.Models.Application
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? CreatedAt { get; set; }

        [StringLength(128)]
        public string? CreatedBy { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? UpdatedAt { get; set; }

        [StringLength(128)]
        public string? UpdatedBy { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DeletedAt { get; set; }

        [StringLength(128)]
        public string? DeletedBy { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
