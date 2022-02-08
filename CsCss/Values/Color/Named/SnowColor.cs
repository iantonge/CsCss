namespace CsCss.Values.Color.Named
{
    public sealed class SnowColor : NamedColor
    {
        private SnowColor() : base("snow") { }

        internal static readonly SnowColor Snow = new SnowColor();
    }
}