namespace CsCss.Values.Color.Named
{
    public sealed class CyanColor : NamedColor
    {
        private CyanColor() : base("cyan") { }

        internal static readonly CyanColor Cyan = new CyanColor();
    }
}