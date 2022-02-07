namespace CsCss.Values.Color.Named
{
    public sealed class DarkGreyColor: NamedColor
    {
        private DarkGreyColor() : base("darkgrey") { }

        internal static readonly DarkGreyColor DarkGrey = new DarkGreyColor();
    }
}
