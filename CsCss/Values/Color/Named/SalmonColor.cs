namespace CsCss.Values.Color.Named
{
    public sealed class SalmonColor : NamedColor
    {
        private SalmonColor() : base("salmon") { }

        internal static readonly SalmonColor Salmon = new SalmonColor();
    }
}