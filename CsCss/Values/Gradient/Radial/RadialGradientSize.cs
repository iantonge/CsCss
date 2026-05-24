namespace CsCss.Values.Gradient.Radial;

public sealed class RadialGradientSize : Value
{
    private RadialGradientSize(string v) : base(v) { }

    internal static readonly RadialGradientSize ClosestSide = new("closest-side");
    internal static readonly RadialGradientSize FarthestSide = new("farthest-side");
    internal static readonly RadialGradientSize ClosestCorner = new("closest-corner");
    internal static readonly RadialGradientSize FarthestCorner = new("farthest-corner");
}
