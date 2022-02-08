using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Color.Function
{
    public sealed class HwbValue : ColorValue
    {
        internal HwbValue(HueValue hue, PercentageValue whiteness, PercentageValue blackness, AlphaValue? alpha)
            : base($"hwb({hue} {whiteness} {blackness}{(alpha is null ? string.Empty : " / " + alpha)})")
        {
        }
    }
}
