namespace CsCss.Values.Color.Rgb
{
    public sealed class RgbValue : ColorValue
    {
        internal RgbValue(RedValue red, GreenValue green, BlueValue blue) : base($"rgb(${red},${green},${blue})")
        {
        }
    }
}
