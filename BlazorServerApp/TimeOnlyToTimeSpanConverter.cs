using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServerApp
{
    public class TimeOnlyToTimeSpanConverter : ValueConverter<TimeOnly, TimeSpan>
    {
        public TimeOnlyToTimeSpanConverter()
            : base(
                v => v.ToTimeSpan(),
                v => TimeOnly.FromTimeSpan(v))
        {
        }
    }
}
