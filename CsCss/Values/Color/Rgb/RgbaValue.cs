namespace CsCss.Values.Color.Rgb
{
    public sealed class RgbaValue : ColorValue
    {
        internal RgbaValue(RedValue red, GreenValue green, BlueValue blue, AlphaValue alpha)
            : base($"rgba(${red},${green},${blue},${alpha})")
        {
        }
    }
}
