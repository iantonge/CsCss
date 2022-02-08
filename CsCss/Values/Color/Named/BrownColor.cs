namespace CsCss.Values.Color.Named
{
    public sealed class BrownColor : NamedColor
    {
        private BrownColor() : base("brown") { }

        internal static readonly BrownColor Brown = new BrownColor();
    }
}