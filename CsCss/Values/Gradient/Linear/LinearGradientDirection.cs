using CsCss.Values.Angle;

namespace CsCss.Values.Gradient.Linear
{
    public sealed class LinearGradientDirection
    {
        private readonly string value;

        private LinearGradientDirection(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator LinearGradientDirection(AngleValue value)
        {
            return new LinearGradientDirection(value.ToString());
        }

        internal static readonly LinearGradientDirection ToLeftTop = new LinearGradientDirection("to left top");
        internal static readonly LinearGradientDirection ToTop = new LinearGradientDirection("to top");
        internal static readonly LinearGradientDirection ToRightTop = new LinearGradientDirection("to right top");
        internal static readonly LinearGradientDirection ToRight = new LinearGradientDirection("to right");
        internal static readonly LinearGradientDirection ToRightBottom = new LinearGradientDirection("to right bottom");
        internal static readonly LinearGradientDirection ToBottom = new LinearGradientDirection("to bottom");
        internal static readonly LinearGradientDirection ToLeftBottom = new LinearGradientDirection("to left bottom");
        internal static readonly LinearGradientDirection ToLeft = new LinearGradientDirection("to left");
    }
}
