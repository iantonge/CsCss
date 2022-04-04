namespace CsCss.Properties.BorderColor
{
    public sealed class BorderColorProperty : Property
    {
        private BorderColorProperty(string v) : base(v) { }

        internal static readonly BorderColorProperty BorderColor = new BorderColorProperty("border-color");
        internal static readonly BorderColorProperty BorderTopColor = new BorderColorProperty("border-top-color");
        internal static readonly BorderColorProperty BorderBottomColor = new BorderColorProperty("border-bottom-color");
        internal static readonly BorderColorProperty BorderLeftColor = new BorderColorProperty("border-left-color");
        internal static readonly BorderColorProperty BorderRightColor = new BorderColorProperty("border-right-color");
    }
}
