using CsCss.Values.Color.Hsl;

namespace CsCss
{
    public static partial class Statics
    {
        public static HslValue Hsl(HueValue hue, SaturationValue saturation, LightnessValue lightness)
        {
            return new HslValue(hue, saturation, lightness);
        }

        public static HslaValue Hsla(HueValue hue, SaturationValue saturation, LightnessValue lightness, AlphaValue alpha)
        {
            return new HslaValue(hue, saturation, lightness, alpha);
        }
    }
}
