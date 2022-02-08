namespace CsCss.Values.Color.Named
{
    public sealed class DarkRedColor : NamedColor
    {
        private DarkRedColor() : base("darkred") { }

        internal static readonly DarkRedColor DarkRed = new DarkRedColor();
    }
}