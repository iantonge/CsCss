namespace CsCss.Values.Gradient.Radial;

public sealed class RadialGradientShape : Value
{
    private RadialGradientShape(string v) : base(v) { }

    internal static readonly RadialGradientShape Circle = new("circle");
    internal static readonly RadialGradientShape Ellipse = new("ellipse");
}
