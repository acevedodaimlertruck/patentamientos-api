using LCH.MercedesBenz.Api.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.FechaCierres
{
    [Table("FechaCierre")]
    public class FechaCierre : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? ZFechaCierre { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? ZFechaDia { get; set; }

        public TimeSpan? ZHoraDia { get; set; }
    }
}
