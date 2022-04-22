namespace CsCss.Properties.BorderWidth
{
    public sealed class DirectionalBorderWidthProperty : Property
    {
        private DirectionalBorderWidthProperty(string v) : base(v) { }

        internal static readonly DirectionalBorderWidthProperty BorderTopWidth = new DirectionalBorderWidthProperty("border-top-width");
        internal static readonly DirectionalBorderWidthProperty BorderBottomWidth = new DirectionalBorderWidthProperty("border-bottom-width");
        internal static readonly DirectionalBorderWidthProperty BorderLeftWidth = new DirectionalBorderWidthProperty("border-left-width");
        internal static readonly DirectionalBorderWidthProperty BorderRightWidth = new DirectionalBorderWidthProperty("border-right-width");
    }
}
