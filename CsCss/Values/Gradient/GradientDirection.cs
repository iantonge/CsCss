using CsCss.Values.Angle;

namespace CsCss.Values.Gradient
{
    public sealed class GradientDirection
    {
        private readonly string value;

        private GradientDirection(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator GradientDirection(AngleValue value)
        {
            return new GradientDirection(value.ToString());
        }

        internal static readonly GradientDirection ToLeftTop = new GradientDirection("to left top");
        internal static readonly GradientDirection ToTop = new GradientDirection("to top");
        internal static readonly GradientDirection ToRightTop = new GradientDirection("to right top");
        internal static readonly GradientDirection ToRight = new GradientDirection("to right");
        internal static readonly GradientDirection ToRightBottom = new GradientDirection("to right bottom");
        internal static readonly GradientDirection ToBottom = new GradientDirection("to bottom");
        internal static readonly GradientDirection ToLeftBottom = new GradientDirection("to left bottom");
        internal static readonly GradientDirection ToLeft = new GradientDirection("to left");
    }
}
