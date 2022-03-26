using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;

namespace CsCss.Values.Gradient
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
