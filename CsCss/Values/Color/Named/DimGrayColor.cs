namespace CsCss.Values.Color.Named
{
    public sealed class DimGrayColor : NamedColor
    {
        private DimGrayColor() : base("dimgray") { }

        internal static readonly DimGrayColor DimGray = new DimGrayColor();
    }
}