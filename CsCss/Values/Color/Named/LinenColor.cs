namespace CsCss.Values.Color.Named
{
    public sealed class LinenColor : NamedColor
    {
        private LinenColor() : base("linen") { }

        internal static readonly LinenColor Linen = new LinenColor();
    }
}