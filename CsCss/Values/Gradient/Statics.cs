using CsCss.Values.Gradient;

namespace CsCss
{
    public static partial class Statics
    {
        public static readonly GradientDirection ToLeftTop = GradientDirection.ToLeftTop;
        public static readonly GradientDirection ToTop = GradientDirection.ToTop;
        public static readonly GradientDirection ToRightTop = GradientDirection.ToRightTop;
        public static readonly GradientDirection ToRight = GradientDirection.ToRight;
        public static readonly GradientDirection ToRightBottom = GradientDirection.ToRightBottom;
        public static readonly GradientDirection ToBottom = GradientDirection.ToBottom;
        public static readonly GradientDirection ToLeftBottom = GradientDirection.ToLeftBottom;
        public static readonly GradientDirection ToLeft = GradientDirection.ToLeft;

        public static readonly RadialGradientShape Circle = RadialGradientShape.Circle;
        public static readonly RadialGradientShape Ellipse = RadialGradientShape.Ellipse;

        public static readonly RadialGradientSize ClosestSide = RadialGradientSize.ClosestSide;
        public static readonly RadialGradientSize FarthestSide = RadialGradientSize.FarthestSide;
        public static readonly RadialGradientSize ClosestCorner = RadialGradientSize.ClosestCorner;
        public static readonly RadialGradientSize FarthestCorner = RadialGradientSize.FarthestCorner;

        public static RadialGradientBuilder BuildRadialGradient()
        {
            return new RadialGradientBuilder("radial-gradient");
        }

        public static RadialGradientBuilder BuildRepeatingRadialGradient()
        {
            return new RadialGradientBuilder("repeating-radial-gradient");
        }

        public static ILinearGradientBuilderWithoutStops BuildLinearGradient()
        {
            return new LinearGradientBuilder("linear-gradient");
        }

        public static ILinearGradientBuilderWithoutStops BuildLinearGradient(GradientDirection direction)
        {
            return new LinearGradientBuilder("linear-gradient", direction);
        }

        public static ILinearGradientBuilderWithoutStops BuildRepeatingLinearGradient()
        {
            return new LinearGradientBuilder("repeating-linear-gradient");
        }

        public static ILinearGradientBuilderWithoutStops BuildRepeatingLinearGradient(GradientDirection direction)
        {
            return new LinearGradientBuilder("repeating-linear-gradient", direction);
        }
    }
}
