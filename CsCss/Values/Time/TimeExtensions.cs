using CsCss.Values.Time;

namespace CsCss;

public static class TimeExtensions
{
    public static TimeValue S(this double input) => new TimeValue(input, TimeUnit.S);

    public static TimeValue S(this int input) => new TimeValue(input, TimeUnit.S);

    public static TimeValue Ms(this double input) => new TimeValue(input, TimeUnit.Ms);

    public static TimeValue Ms(this int input) => new TimeValue(input, TimeUnit.Ms);
}
