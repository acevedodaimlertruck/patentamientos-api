namespace LCH.MercedesBenz.Api.Models.Application
{
    public class SortBy<T>
    {
        public Func<T, object>? OrderBy { get; set; }
        public Func<T, object>? OrderByDescending { get; set; }

        public SortBy()
        {
            OrderBy = null;
            OrderByDescending = null;
        }
    }
}
