﻿using LCH.MercedesBenz.Api.Attributes;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.OdsWholesales;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.Grados
{
    [Table("Grados")]
    public class Grado : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        [StringLength(4)]
        public string MarcaWs { get; set; } = string.Empty;

        [Required]
        [StringLength(5)]
        public string ModeloWs { get; set; } = string.Empty;

        [Required]
        [StringLength(7)]
        public string Grade { get; set; } = string.Empty;

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateTo { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DateFrom { get; set; }

        [StringLength(3)]
        public string? MercedesTerminalId { get; set; }

        [StringLength(3)]
        public string? MercedesMarcaId { get; set; }

        [StringLength(3)]
        public string? MercedesModeloId { get; set; }

        [Required]
        public Guid CarModelId { get; set; }

        public CarModel? CarModel { get; set; }

        [StringLength(4)]
        public string? VersionWs { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-ddTHH:mm:ss.fffZ")]
        public DateTime? DischargeDate { get; set; } // Fecha de Alta

        [JsonIgnore]
        public virtual ICollection<OdsWholesale> OdsWholesales { get; set; } = new HashSet<OdsWholesale>();
    }
}