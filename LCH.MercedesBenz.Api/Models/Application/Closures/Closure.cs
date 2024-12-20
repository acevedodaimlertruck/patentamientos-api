using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.Patentings;

namespace LCH.MercedesBenz.Api.Models.Application.Closures
{
    [Table("Closures")]
    public class Closure : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? FechaCorte { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? FechaCreacion { get; set; }

        public string HoraCreacion { get; set; }

        public bool EsUltimo { get; set; } = false;

        [JsonIgnore]
        public virtual ICollection<Patenting> Patentings { get; set; } = new HashSet<Patenting>();

    }
}
