namespace CsCss.Values.Color.Named
{
    public sealed class YellowColor: NamedColor
    {
        private YellowColor() : base("yellow") { }

        internal static readonly YellowColor Yellow = new YellowColor();
    }
}
