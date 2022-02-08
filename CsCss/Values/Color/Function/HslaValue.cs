using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Function
{
    public sealed class HslaValue : ColorValue
    {
        internal HslaValue(HueValue hue, PercentageValue saturation, PercentageValue lightness, AlphaValue alpha)
            : base($"hsla({hue},{saturation},{lightness},{alpha})")
        {
        }
    }
}
