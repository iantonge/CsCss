namespace CsCss.Values.Color.Hsl
{
    public sealed class HslaValue : ColorValue
    {
        internal HslaValue(HueValue hue, SaturationValue saturation, LightnessValue lightness, AlphaValue alpha)
            : base($"hsla(${hue},${saturation},${lightness},${alpha})")
        {
        }
    }
}
