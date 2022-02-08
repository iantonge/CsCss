namespace CsCss.Values.Color.Named
{
    public sealed class GreenColor : NamedColor
    {
        private GreenColor() : base("green") { }

        internal static readonly GreenColor Green = new GreenColor();
    }
}