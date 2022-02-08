namespace CsCss.Values.Color.Named
{
    public sealed class GoldColor : NamedColor
    {
        private GoldColor() : base("gold") { }

        internal static readonly GoldColor Gold = new GoldColor();
    }
}