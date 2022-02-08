namespace CsCss.Values.Color.Named
{
    public sealed class PinkColor : NamedColor
    {
        private PinkColor() : base("pink") { }

        internal static readonly PinkColor Pink = new PinkColor();
    }
}