namespace CsCss.Values.Color.Named
{
    public sealed class LimeColor: NamedColor
    {
        private LimeColor() : base("lime") { }

        internal static readonly LimeColor Lime = new LimeColor();
    }
}
