using CsCss.Properties.Color;
using CsCss.Values.LengthPercentage;

namespace CsCss.Values.Gradient
{
    internal sealed class ColorStop : GradientParameter
    {
        internal ColorStop(ColorValue color) : base(color.ToString()) { }

        internal ColorStop(ColorValue color, LengthPercentageValue from)
            : base(color.ToString() + " " + from.ToString()) { }

        internal ColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to)
            : base(color.ToString() + " " + from.ToString() + " " + to.ToString()) { }
    }
}
