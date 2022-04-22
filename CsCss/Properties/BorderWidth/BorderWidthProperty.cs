namespace CsCss.Properties.BorderWidth
{
    public sealed class BorderWidthProperty : Property
    {
        private BorderWidthProperty() : base("border-width") { }

        internal static readonly BorderWidthProperty BorderWidth = new BorderWidthProperty();
    }
}
