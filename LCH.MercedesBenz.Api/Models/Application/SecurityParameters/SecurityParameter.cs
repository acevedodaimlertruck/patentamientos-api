using System.ComponentModel.DataAnnotations.Schema;

namespace LCH.MercedesBenz.Api.Models.Application.SecurityParameters
{
    [Table("SecurityParameters")]
    public class SecurityParameter : BaseEntity
    {
        public int AutoId { get; set; } = 0;

        public int SessionTime { get; set; }

        public int NumberLogins { get; set; }

        public int MinCharacters { get; set; }

        public int MaxCharacters { get; set; }

        public bool IncludeCapitalLetter { get; set; } = false;

        public bool IncludeNumbers { get; set; } = false;

        public bool IncludeSpecialCharacters { get; set; } = false;
    }
}
