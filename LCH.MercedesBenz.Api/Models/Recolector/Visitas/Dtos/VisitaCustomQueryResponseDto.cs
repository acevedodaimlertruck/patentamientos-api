using LCH.MercedesBenz.Api.Models.Application;

namespace LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos
{
    public class VisitaCustomQueryResponseDto
    {
        /// <summary>
        /// Código de usuario
        /// </summary>
        public string CodUsuario { get; set; }

        /// <summary>
        /// Código de versión
        /// </summary>
        public string CodVersion { get; set; }

        /// <summary>
        /// Paginado
        /// </summary>
        public Page Page { get; set; }

        /// <summary>
        /// Orden
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Filtro
        /// </summary>
        public Filter Filter { get; set; }

        /// <summary>
        /// Resultado de la consulta
        /// </summary>
        public ICollection<VisitaDto> Results { get; set; }
    }
}