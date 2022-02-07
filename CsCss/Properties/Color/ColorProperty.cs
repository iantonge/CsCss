namespace CsCss.Properties.Color
{
    public sealed class ColorProperty : Property
    {
        private ColorProperty() : base("color") { }

        internal static readonly ColorProperty Color = new ColorProperty();
    }
}
