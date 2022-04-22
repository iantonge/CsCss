namespace CsCss.Properties.BorderStyle
{
    public sealed class BorderStyleProperty : Property
    {
        private BorderStyleProperty() : base("border-style") { }

        internal static readonly BorderStyleProperty BorderStyle = new BorderStyleProperty();
    }
}
