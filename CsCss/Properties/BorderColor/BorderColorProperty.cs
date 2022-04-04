namespace CsCss.Properties.BorderColor
{
    public sealed class BorderColorProperty : Property
    {
        private BorderColorProperty() : base("border-color") { }

        internal static readonly BorderColorProperty BorderColor = new BorderColorProperty();
    }
}
