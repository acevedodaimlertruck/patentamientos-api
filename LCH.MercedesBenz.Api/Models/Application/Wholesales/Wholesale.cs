﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Wholesales
{
    [Table("Wholesales")]
    public class Wholesale : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileId { get; set; }

        public File? File { get; set; }

        [Required]
        [StringLength(128)]
        public string YearMonth { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string CodBrand { get; set; } = string.Empty;

        [StringLength(128)]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string CodModel { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string CodTrademark { get; set; } = string.Empty;

        [Required]
        [StringLength(512)]
        public string Trademark { get; set; } = string.Empty;

        [Required]
        public string DoorsQty { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Engine { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string MotorType { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string FuelType { get; set; } = string.Empty;

        [Required]
        public string Power { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string PowerUnit { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string VehicleType { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Traction { get; set; } = string.Empty;

        [Required]
        public string GearsQty { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string TransmissionType { get; set; } = string.Empty;

        [Required]
        public string AxleQty { get; set; } = string.Empty;

        [Required]
        public string Weight { get; set; } = string.Empty;

        [Required]
        public string LoadCapacity { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Category { get; set; } = string.Empty;

        [Required]
        [StringLength(128)]
        public string Origin { get; set; } = string.Empty;

        public string InitialStock { get; set; } = string.Empty;

        public string Import_ProdMonth { get; set; } = string.Empty;

        public string Import_ProdAccum { get; set; } = string.Empty;

        public string MonthlySale { get; set; } = string.Empty;

        public string MonthlyAccum { get; set; } = string.Empty;

        public string ExportMonthly { get; set; } = string.Empty;

        public string ExportAccum { get; set; } = string.Empty;

        public string SavingSystemMonthly { get; set; } = string.Empty;

        public string SavingSystemAccum { get; set; } = string.Empty;

        public string FinalStock { get; set; } = string.Empty;

        public string NoOkStock { get; set; } = string.Empty;
    }
}