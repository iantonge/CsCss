namespace CsCss.Values.Color.Named
{
    public sealed class GoldenRodColor : NamedColor
    {
        private GoldenRodColor() : base("goldenrod") { }

        internal static readonly GoldenRodColor GoldenRod = new GoldenRodColor();
    }
}