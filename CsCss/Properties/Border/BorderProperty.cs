namespace CsCss.Properties.Border
{
    public sealed class BorderProperty : Property
    {
        private BorderProperty(string v) : base(v) { }

        internal static readonly BorderProperty Border = new BorderProperty("border");
        internal static readonly BorderProperty BorderTop = new BorderProperty("border-top");
        internal static readonly BorderProperty BorderBottom = new BorderProperty("border-bottom");
        internal static readonly BorderProperty BorderLeft = new BorderProperty("border-left");
        internal static readonly BorderProperty BorderRight = new BorderProperty("border-right");
    }
}
