namespace CsCss.Properties.Border
{
    public sealed class BorderProperty : Property
    {
        private BorderProperty() : base("border") { }

        internal static readonly BorderProperty Border = new BorderProperty();
    }
}
