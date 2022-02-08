namespace CsCss.Values.Color.Named
{
    public sealed class DarkGrayColor : NamedColor
    {
        private DarkGrayColor() : base("darkgray") { }

        internal static readonly DarkGrayColor DarkGray = new DarkGrayColor();
    }
}