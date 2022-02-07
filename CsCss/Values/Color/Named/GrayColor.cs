namespace CsCss.Values.Color.Named
{
    public sealed class GrayColor: NamedColor
    {
        private GrayColor() : base("gray") { }

        internal static readonly GrayColor Gray = new GrayColor();
    }
}
