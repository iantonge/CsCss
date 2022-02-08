namespace CsCss.Values.Color.Named
{
    public sealed class LightGrayColor : NamedColor
    {
        private LightGrayColor() : base("lightgray") { }

        internal static readonly LightGrayColor LightGray = new LightGrayColor();
    }
}