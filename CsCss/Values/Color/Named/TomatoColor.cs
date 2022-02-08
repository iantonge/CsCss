namespace CsCss.Values.Color.Named
{
    public sealed class TomatoColor : NamedColor
    {
        private TomatoColor() : base("tomato") { }

        internal static readonly TomatoColor Tomato = new TomatoColor();
    }
}