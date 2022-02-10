using CsCss.Values.Color.Function;
using CsCss.Values.Percentage;

namespace CsCss
{
    public static partial class Statics
    {
        public static HslValue Hsl(HueValue hue, PercentageValue saturation, PercentageValue lightness)
        {
            return new HslValue(hue, saturation, lightness);
        }

        public static HslaValue Hsla(HueValue hue, PercentageValue saturation, PercentageValue lightness, AlphaValue alpha)
        {
            return new HslaValue(hue, saturation, lightness, alpha);
        }

        public static HwbValue Hwb(HueValue hue, PercentageValue whiteness, PercentageValue blackness, AlphaValue? alpha = null)
        {
            return new HwbValue(hue, whiteness, blackness, alpha);
        }

        public static RgbValue Rgb(RgbComponent red, RgbComponent green, RgbComponent blue)
        {
            return new RgbValue(red, green, blue);
        }

        public static RgbaValue Rgba(RgbComponent red, RgbComponent green, RgbComponent blue, AlphaValue alpha)
        {
            return new RgbaValue(red, green, blue, alpha);
        }
    }
}
