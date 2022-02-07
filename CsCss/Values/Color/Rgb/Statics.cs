using CsCss.Values.Color.Rgb;

namespace CsCss
{
    public static partial class Statics
    {
        public static RgbValue Rgb(RedValue red, GreenValue green, BlueValue blue)
        {
            return new RgbValue(red, green, blue);
        }

        public static RgbaValue Rgba(RedValue red, GreenValue green, BlueValue blue, AlphaValue alpha)
        {
            return new RgbaValue(red, green, blue, alpha);
        }
    }
}
