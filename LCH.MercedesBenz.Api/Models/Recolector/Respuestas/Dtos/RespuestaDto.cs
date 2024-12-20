using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LCH.MercedesBenz.Api.Models.Recolector.Modulos.Dtos;
using LCH.MercedesBenz.Api.Models.Recolector.Versiones.Dtos;

namespace LCH.MercedesBenz.Api.Models.Recolector.Respuestas.Dtos
{
    public class RespuestaDto
    {
        public int IdRespuesta { get; set; }

        [StringLength(100)]
        public string TipoDatoCodigo { get; set; }

        [StringLength(100)]
        public string CodVisita { get; set; }

        [StringLength(100)]
        public string CodPreguntaSeccion { get; set; }

        [StringLength(100)]
        public string CodDetallePregunta { get; set; }

        [StringLength(255)]
        public string CodOpcion { get; set; }

        [StringLength(100)]
        public string CodEntidad { get; set; }

        [StringLength(8000)]
        public string RespuestaAlfanumerico { get; set; }

        [StringLength(255)]
        public string Agrupamiento { get; set; }

        [StringLength(100)]
        public string CodBloque { get; set; }
    }
}