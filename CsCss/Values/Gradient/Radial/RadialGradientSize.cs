namespace CsCss.Values.Gradient.Radial
{
    public sealed class RadialGradientSize : Value
    {
        private RadialGradientSize(string v) : base(v) { }

        internal static readonly RadialGradientSize ClosestSide = new RadialGradientSize("closest-side");
        internal static readonly RadialGradientSize FarthestSide = new RadialGradientSize("farthest-side");
        internal static readonly RadialGradientSize ClosestCorner = new RadialGradientSize("closest-corner");
        internal static readonly RadialGradientSize FarthestCorner = new RadialGradientSize("farthest-corner");
    }
}
