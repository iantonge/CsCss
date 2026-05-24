using CsCss.Values.Gradient.Linear;

namespace CsCss;

public static partial class Functions
{
    public static ILinearGradientBuilder BuildLinearGradient() => new LinearGradientBuilder("linear-gradient");

    public static ILinearGradientBuilder BuildRepeatingLinearGradient() => new LinearGradientBuilder("repeating-linear-gradient");
}
