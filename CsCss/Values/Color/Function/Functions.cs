using CsCss.Values.Color.Function;
using CsCss.Values.Percentage;

namespace CsCss;

public static partial class Functions
{
    public static HslValue Hsl(HueValue hue, PercentageValue saturation, PercentageValue lightness) => new HslValue(hue, saturation, lightness);

    public static HslaValue Hsla(HueValue hue, PercentageValue saturation, PercentageValue lightness, AlphaValue alpha) => new HslaValue(hue, saturation, lightness, alpha);

    public static HwbValue Hwb(HueValue hue, PercentageValue whiteness, PercentageValue blackness, AlphaValue? alpha = null) => new HwbValue(hue, whiteness, blackness, alpha);

    public static RgbValue Rgb(RgbComponent red, RgbComponent green, RgbComponent blue) => new RgbValue(red, green, blue);

    public static RgbaValue Rgba(RgbComponent red, RgbComponent green, RgbComponent blue, AlphaValue alpha) => new RgbaValue(red, green, blue, alpha);
}
