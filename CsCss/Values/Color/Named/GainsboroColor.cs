namespace CsCss.Values.Color.Named
{
    public sealed class GainsboroColor : NamedColor
    {
        private GainsboroColor() : base("gainsboro") { }

        internal static readonly GainsboroColor Gainsboro = new GainsboroColor();
    }
}