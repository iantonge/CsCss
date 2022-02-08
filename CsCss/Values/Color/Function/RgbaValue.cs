namespace CsCss.Values.Color.Function
{
    public sealed class RgbaValue : ColorValue
    {
        internal RgbaValue(RgbComponent red, RgbComponent green, RgbComponent blue, AlphaValue alpha)
            : base($"rgba({red},{green},{blue},{alpha})")
        {
        }
    }
}
