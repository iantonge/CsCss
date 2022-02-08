namespace CsCss.Values.Color.Function
{
    public sealed class RgbValue : ColorValue
    {
        internal RgbValue(RgbComponent red, RgbComponent green, RgbComponent blue)
            : base($"rgb({red},{green},{blue})")
        {
        }
    }
}
