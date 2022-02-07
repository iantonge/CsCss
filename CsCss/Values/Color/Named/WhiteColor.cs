namespace CsCss.Values.Color.Named
{
    public sealed class WhiteColor: NamedColor
    {
        private WhiteColor() : base("white") { }

        internal static readonly WhiteColor White = new WhiteColor();
    }
}
