namespace CsCss.Values.Color.Named
{
    public sealed class ChocolateColor : NamedColor
    {
        private ChocolateColor() : base("chocolate") { }

        internal static readonly ChocolateColor Chocolate = new ChocolateColor();
    }
}