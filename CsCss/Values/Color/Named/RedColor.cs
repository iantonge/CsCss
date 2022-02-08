namespace CsCss.Values.Color.Named
{
    public sealed class RedColor : NamedColor
    {
        private RedColor() : base("red") { }

        internal static readonly RedColor Red = new RedColor();
    }
}