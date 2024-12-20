using System.Linq.Expressions;

namespace LCH.MercedesBenz.Api.Models.Application
{
    public class Query<T>
    {
        public int Page { get; set; }

        public int Top { get; set; }

        public Expression<Func<T, bool>>? Where { get; set; }

        public Func<T, object>? OrderBy { get; set; }

        public Func<T, object>? OrderByDescending { get; set; }

        public Query(int page, int top)
        {
            Page = page;
            Top = top;
            Where = null;
            OrderBy = null;
            OrderByDescending = null;
        }
    }
}
