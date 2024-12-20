using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Recolector.Viviendas.Dtos
{
    public class ViviendaDto
    {
        public int IdVivienda { get; set; }

        [Required]
        [StringLength(128)]
        public string CodVivienda { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CodVisita { get; set; } = string.Empty;

        public decimal? GpsX { get; set; }

        public decimal? GpsY { get; set; }

        public double? GpsAltura { get; set; }

        public double? GpsRangoDisp { get; set; }

        public Geometry? GpsGeo { get; set; }

        public int? Nim { get; set; }

        [StringLength(50)]
        public string? ParcelaInt { get; set; }

        [StringLength(50)]
        public string? GpsTexto { get; set; }

        [StringLength(256)]
        public string? BarrioObs { get; set; }

        [StringLength(256)]
        public string? CalleObs { get; set; }

        [StringLength(256)]
        public string? ZonaObs { get; set; }

        [StringLength(-1)]
        public string? Referencias { get; set; }

        [StringLength(100)]
        public string? PaisCod { get; set; }

        [StringLength(100)]
        public string? ProvCod { get; set; }

        [StringLength(100)]
        public string? DepartamentoCod { get; set; }

        [StringLength(100)]
        public string? MunicipioCod { get; set; }

        [StringLength(100)]
        public string? LocalidadCod { get; set; }

        [StringLength(100)]
        public string? ParajeCod { get; set; }

        [StringLength(100)]
        public string? ZonaCod { get; set; }

        [StringLength(100)]
        public string? BarrioCod { get; set; }

        [StringLength(50)]
        public string? ManzanaNum { get; set; }

        [StringLength(50)]
        public string? ManzanaLetra { get; set; }

        [StringLength(50)]
        public string? ParcelaNum { get; set; }

        [StringLength(100)]
        public string? CalleNombre { get; set; }

        [StringLength(50)]
        public string? PuertaCasaNumero { get; set; }

        [StringLength(50)]
        public string? PuertaCasaNumeroInterior { get; set; }

        [StringLength(50)]
        public string? Torre { get; set; }

        [StringLength(50)]
        public string? Block { get; set; }

        [StringLength(50)]
        public string? Piso { get; set; }

        [StringLength(50)]
        public string? Depto { get; set; }

        [StringLength(100)]
        public string? Lote { get; set; }
    }
}