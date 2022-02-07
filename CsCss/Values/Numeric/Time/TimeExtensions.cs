using CsCss.Values.Numeric.Time;

namespace CsCss
{
    public static class TimeExtensions
    {
        public static TimeValue S(this double input)
        {
            return new TimeValue(input, TimeUnit.S);
        }

        public static TimeValue S(this int input)
        {
            return new TimeValue(input, TimeUnit.S);
        }

        public static TimeValue Ms(this double input)
        {
            return new TimeValue(input, TimeUnit.Ms);
        }

        public static TimeValue Ms(this int input)
        {
            return new TimeValue(input, TimeUnit.Ms);
        }
    }
}
