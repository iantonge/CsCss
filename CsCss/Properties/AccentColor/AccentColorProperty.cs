namespace CsCss.Properties.AccentColor
{
    public sealed class AccentColorProperty : Property
    {
        private AccentColorProperty() : base("accent-color") { }

        internal static readonly AccentColorProperty AccentColor = new AccentColorProperty();
    }
}
