using System.Linq.Expressions;

namespace LCH.MercedesBenz.Api.Models.Recolector.Visitas.Dtos
{
    public class VisitaCustomQueryDto
    {
        public int Page { get; set; }
        public int Top { get; set; }
        public Expression<Func<VisitaEntity, bool>> Where { get; set; }
        public Func<VisitaDto, object> OrderBy { get; set; }
        public Func<VisitaDto, object> OrderByDescending { get; set; }

        public VisitaCustomQueryDto(int page, int top)
        {
            Page = page;
            Top = top;
            Where = null;
            OrderBy = null;
            OrderByDescending = null;
        }
    }
}