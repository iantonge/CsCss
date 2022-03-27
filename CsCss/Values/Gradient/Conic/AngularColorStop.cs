using CsCss.Properties.Color;
using CsCss.Values.AnglePercentage;

namespace CsCss.Values.Gradient.Conic
{
    internal sealed class AngularColorStop : AngularColorStopItem
    {
        internal AngularColorStop(ColorValue color) : base(color.ToString()) { }

        internal AngularColorStop(ColorValue color, AnglePercentageValue from)
            : base(color.ToString() + " " + from.ToString()) { }

        internal AngularColorStop(ColorValue color, AnglePercentageValue from, AnglePercentageValue to)
            : base(color.ToString() + " " + from.ToString() + " " + to.ToString()) { }
    }
}
