using Newtonsoft.Json.Converters;

namespace LCH.MercedesBenz.Api.Attributes
{
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
