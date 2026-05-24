using CsCss.Properties.Color;
using CsCss.Values.LengthPercentage;

namespace CsCss.Values.Gradient;

internal sealed class LinearColorStop : LinearColorStopItem
{
    internal LinearColorStop(ColorValue color) : base(color.ToString()) { }

    internal LinearColorStop(ColorValue color, LengthPercentageValue from)
        : base($"{color} {from}") { }

    internal LinearColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to)
        : base($"{color} {from} {to}") { }
}
