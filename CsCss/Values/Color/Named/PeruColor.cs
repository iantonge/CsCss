namespace CsCss.Values.Color.Named
{
    public sealed class PeruColor : NamedColor
    {
        private PeruColor() : base("peru") { }

        internal static readonly PeruColor Peru = new PeruColor();
    }
}