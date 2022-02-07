namespace CsCss.Values.Color.Hsl
{
    public sealed class HslValue : ColorValue
    {
        internal HslValue(HueValue hue, SaturationValue saturation, LightnessValue lightness) : base($"hsl(${hue},${saturation},${lightness})")
        {
        }
    }
}
