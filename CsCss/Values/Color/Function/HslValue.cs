using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Function
{
    public sealed class HslValue : ColorValue
    {
        internal HslValue(HueValue hue, PercentageValue saturation, PercentageValue lightness)
            : base($"hsl({hue},{saturation},{lightness})")
        {
        }
    }
}
