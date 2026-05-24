using CsCss.Values.Percentage;

namespace CsCss;

public static class PercentageExtensions
{
    public static PercentageValue Percent(this double input) => new(input, PercentageUnit.Percent);

    public static PercentageValue Percent(this int input) => new(input, PercentageUnit.Percent);
}
