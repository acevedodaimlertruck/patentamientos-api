using LCH.MercedesBenz.Api.Models.Application.Files;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.SpecialSales.Dtos
{
    public class SpecialSaleSpa : BaseDto
    {
        public int AutoId { get; set; } = 0;
        public Guid FileId { get; set; }
        public File? File { get; set; }
        public string CUIT_Titular { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public string Persona_Juridica { get; set; } = string.Empty;
        public string Desc_Persona_Juridica { get; set; } = string.Empty;
        public string Clasificacion_Gubernamental { get; set; } = string.Empty;
        public string Desc_Clasificacion_Gubernamental { get; set; } = string.Empty;
        public string Subclasificacion_Gubernamental { get; set; } = string.Empty;
        public string Desc_Subclasificacion_Gubernamental { get; set; } = string.Empty;
        public string Clasificacion_CUIT { get; set; } = string.Empty;
        public string Desc_Clasificacion_CUIT { get; set; } = string.Empty;
        public string Apertura1 { get; set; } = string.Empty;
        public string Desc_Apertura1 { get; set; } = string.Empty;
        public string Apertura2 { get; set; } = string.Empty;
        public string Desc_Apertura2 { get; set; } = string.Empty;
        public string Clasificacion_Logistica { get; set; } = string.Empty;
        public string Desc_Clasificacion_Logistica { get; set; } = string.Empty;
        public string Facturacion_Estimada { get; set; } = string.Empty;
        public string Desc_Facturacion_Estimada { get; set; } = string.Empty;
        public string Fecha_de_Contrato_Social { get; set; } = string.Empty;
        public string Info_Empleados { get; set; } = string.Empty;
    }
}
