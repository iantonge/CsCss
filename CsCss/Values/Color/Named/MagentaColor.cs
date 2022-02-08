namespace CsCss.Values.Color.Named
{
    public sealed class MagentaColor : NamedColor
    {
        private MagentaColor() : base("magenta") { }

        internal static readonly MagentaColor Magenta = new MagentaColor();
    }
}