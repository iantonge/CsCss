namespace CsCss.Values.Color.Named
{
    public sealed class AquaColor : NamedColor
    {
        private AquaColor() : base("aqua") { }

        internal static readonly AquaColor Aqua = new AquaColor();
    }
}