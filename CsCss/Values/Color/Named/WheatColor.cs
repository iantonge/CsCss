namespace CsCss.Values.Color.Named
{
    public sealed class WheatColor : NamedColor
    {
        private WheatColor() : base("wheat") { }

        internal static readonly WheatColor Wheat = new WheatColor();
    }
}