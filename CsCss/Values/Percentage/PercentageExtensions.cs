using CsCss.Values.Percentage;

namespace CsCss
{
    public static class PercentageExtensions
    {
        public static PercentageValue Percent(this double input)
        {
            return new PercentageValue(input, PercentageUnit.Percent);
        }

        public static PercentageValue Percent(this int input)
        {
            return new PercentageValue(input, PercentageUnit.Percent);
        }
    }
}
