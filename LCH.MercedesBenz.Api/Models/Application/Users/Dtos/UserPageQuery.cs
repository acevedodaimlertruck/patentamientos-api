using System.Linq.Expressions;
using System;

namespace LCH.MercedesBenz.Api.Models.Application.Users.Dtos
{
    public class UserPageQuery
    {
        public int Page { get; set; }
        public int Top { get; set; }
        public Expression<Func<User, bool>> Where { get; set; }
        public Func<UserDto, object> OrderBy { get; set; }
        public Func<UserDto, object> OrderByDescending { get; set; }

        public UserPageQuery(int page, int top)
        {
            Page = page;
            Top = top;
            Where = null;
            OrderBy = null;
            OrderByDescending = null;
        }
    }
}
