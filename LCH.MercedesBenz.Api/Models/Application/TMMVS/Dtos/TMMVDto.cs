using LCH.MercedesBenz.Api.Models.Application.Brands;
using LCH.MercedesBenz.Api.Models.Application.CarModels;
using LCH.MercedesBenz.Api.Models.Application.Terminals;

namespace LCH.MercedesBenz.Api.Models.Application.TMMVS.Dtos
{
    public class TMMVDto : BaseDto
    {
        public int AutoId { get; set; } = 0;

        public string? VersionPatentamiento { get; set; }

        public string? VersionWs { get; set; }

        public string? VersionInterna { get; set; }

        public string? DescripcionTerminal { get; set; }

        public string? DescripcionMarca { get; set; }

        public string? DescripcionModelo { get; set; }

        public string? DescripcionVerPat { get; set; }

        public string? DescripcionVerWs { get; set; }

        public string? DescripcionVerInt { get; set; }

        //public Guid BrandId { get; set; }

        //public Brand? Brand { get; set; }

        public string? MercedesMarcaId { get; set; } 

        public Guid CarModelId { get; set; }

        public CarModel? CarModel { get; set; }

        public string? MercedesModeloId { get; set; }

        //public Guid TerminalId { get; set; }
        //public Terminal? Terminal { get; set; }

        public string? MercedesTerminalId { get; set; }
    }
}
