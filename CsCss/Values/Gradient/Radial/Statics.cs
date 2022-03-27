using CsCss.Values.Gradient.Radial;

namespace CsCss
{
    public static partial class Statics
    {
        public static readonly RadialGradientShape Circle = RadialGradientShape.Circle;
        public static readonly RadialGradientShape Ellipse = RadialGradientShape.Ellipse;

        public static readonly RadialGradientSize ClosestSide = RadialGradientSize.ClosestSide;
        public static readonly RadialGradientSize FarthestSide = RadialGradientSize.FarthestSide;
        public static readonly RadialGradientSize ClosestCorner = RadialGradientSize.ClosestCorner;
        public static readonly RadialGradientSize FarthestCorner = RadialGradientSize.FarthestCorner;

        public static IRadialGradientBuilder BuildRadialGradient()
        {
            return new RadialGradientBuilder("radial-gradient");
        }

        public static IRadialGradientBuilder BuildRepeatingRadialGradient()
        {
            return new RadialGradientBuilder("repeating-radial-gradient");
        }
    }
}
