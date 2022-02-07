namespace CsCss.Properties.BackgroundColor
{
    public sealed class BackgroundColorProperty : Property
    {
        private BackgroundColorProperty() : base("background-color") { }

        internal static readonly BackgroundColorProperty BackgroundColor = new BackgroundColorProperty();
    }
}
