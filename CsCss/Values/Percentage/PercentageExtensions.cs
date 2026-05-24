using CsCss.Values.Percentage;

namespace CsCss;

public static class PercentageExtensions
{
    public static PercentageValue Percent(this double input) => new PercentageValue(input, PercentageUnit.Percent);

    public static PercentageValue Percent(this int input) => new PercentageValue(input, PercentageUnit.Percent);
}
