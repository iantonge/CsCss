using CsCss.Values.Gradient.Radial;

namespace CsCss;

public static partial class Functions
{
    public static IRadialGradientBuilder BuildRadialGradient() => new RadialGradientBuilder("radial-gradient");

    public static IRadialGradientBuilder BuildRepeatingRadialGradient() => new RadialGradientBuilder("repeating-radial-gradient");
}
