using CsCss.Values.Gradient.Conic;

namespace CsCss;

public static partial class Functions
{
    public static IConicGradientBuilder BuildConicGradient() => new ConicGradientBuilder("conic-gradient");

    public static IConicGradientBuilder BuildRepeatingConicGradient() => new ConicGradientBuilder("repeating-conic-gradient");
}
