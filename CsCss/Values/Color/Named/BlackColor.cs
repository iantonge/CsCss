namespace CsCss.Values.Color.Named
{
    public sealed class BlackColor: NamedColor
    {
        private BlackColor() : base("black") { }

        internal static readonly BlackColor Black = new BlackColor();
    }
}
