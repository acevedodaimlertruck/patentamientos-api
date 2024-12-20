
using LCH.MercedesBenz.Api.Models.Application.CarModels.Dtos;

namespace LCH.MercedesBenz.Api.Models.Application.PatentingVersions.Dtos
{
    public class PatentingVersionDto : BaseDto
    {
        public int AutoId { get; set; } = 0;
        public string? MercedesMarcaId { get; set; } 
        public Guid CarModelId { get; set; } 
        public CarModelDto? CarModel { get; set; } 
        public string? MercedesModeloId { get; set; }  
        public string? MercedesTerminalId { get; set; }
        public string? Version { get; set; }  
        public string? Description { get; set; } 
    }
}
