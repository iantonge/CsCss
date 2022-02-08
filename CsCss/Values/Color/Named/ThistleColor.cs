namespace CsCss.Values.Color.Named
{
    public sealed class ThistleColor : NamedColor
    {
        private ThistleColor() : base("thistle") { }

        internal static readonly ThistleColor Thistle = new ThistleColor();
    }
}