using CsCss.Values.Gradient.Linear;

namespace CsCss
{
    public static partial class Statics
    {
        public static readonly LinearGradientDirection ToLeftTop = LinearGradientDirection.ToLeftTop;
        public static readonly LinearGradientDirection ToTop = LinearGradientDirection.ToTop;
        public static readonly LinearGradientDirection ToRightTop = LinearGradientDirection.ToRightTop;
        public static readonly LinearGradientDirection ToRight = LinearGradientDirection.ToRight;
        public static readonly LinearGradientDirection ToRightBottom = LinearGradientDirection.ToRightBottom;
        public static readonly LinearGradientDirection ToBottom = LinearGradientDirection.ToBottom;
        public static readonly LinearGradientDirection ToLeftBottom = LinearGradientDirection.ToLeftBottom;
        public static readonly LinearGradientDirection ToLeft = LinearGradientDirection.ToLeft;

        public static ILinearGradientBuilder BuildLinearGradient()
        {
            return new LinearGradientBuilder("linear-gradient");
        }

        public static ILinearGradientBuilder BuildRepeatingLinearGradient()
        {
            return new LinearGradientBuilder("repeating-linear-gradient");
        }
    }
}
