namespace CsCss.Values.Color.Named
{
    public sealed class PlumColor : NamedColor
    {
        private PlumColor() : base("plum") { }

        internal static readonly PlumColor Plum = new PlumColor();
    }
}