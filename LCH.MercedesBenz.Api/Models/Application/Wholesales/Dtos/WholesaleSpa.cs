using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using File = LCH.MercedesBenz.Api.Models.Application.Files.File;

namespace LCH.MercedesBenz.Api.Models.Application.Wholesales.Dtos
{
    public class WholesaleSpa : BaseDto
    {
        public int AutoId { get; set; } = 0;

        [Required]
        public Guid FileId { get; set; }

        [JsonIgnore]
        public File? File { get; set; }

        public string AñoMes { get; set; } = string.Empty;

        public string Cod_Marca { get; set; } = string.Empty;

        public string Marca { get; set; } = string.Empty;

        public string Cod_Modelo { get; set; } = string.Empty;

        public string Modelo { get; set; } = string.Empty;
        
        public string Cod_Grado { get; set; } = string.Empty;

        public string Grado { get; set; } = string.Empty;

        public string Cant_Puertas { get; set; } = string.Empty;

        public string Cilindrada { get; set; } = string.Empty;

        public string Tipo_de_Motor { get; set; } = string.Empty;

        public string Tipo_de_Combustible { get; set; } = string.Empty;

        public string Potencia { get; set; } = string.Empty;

        public string Unidad_de_Potencia { get; set; } = string.Empty;

        public string Tipo_de_Vehiculo { get; set; } = string.Empty;

        public string Traccion { get; set; } = string.Empty;

        public string Cantidad_de_Marchas { get; set; } = string.Empty;

        public string Tipo_de_Transmision { get; set; } = string.Empty;

        public string Cantidad_de_Ejes { get; set; } = string.Empty;

        public string Peso { get; set; } = string.Empty;

        public string Capacidad_de_Carga { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public string Origen { get; set; } = string.Empty;

        public string Stock_Inicial { get; set; } = string.Empty;

        public string Import_ProdMes { get; set; } = string.Empty;

        public string Import_ProdAcum { get; set; } = string.Empty;

        public string Venta_Mes { get; set; } = string.Empty;

        public string Venta_Acum { get; set; } = string.Empty;

        public string Export_Mes { get; set; } = string.Empty;

        public string Export_Acum { get; set; } = string.Empty;

        public string Sist_Ahorro_Mes { get; set; } = string.Empty;

        public string Sist_Ahorro_Acum { get; set; } = string.Empty;

        public string Stock_Final { get; set; } = string.Empty;

        public string Stock_NoOk { get; set; } = string.Empty;
    }
}