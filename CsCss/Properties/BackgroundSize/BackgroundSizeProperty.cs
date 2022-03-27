namespace CsCss.Properties.BackgroundSize
{
    public sealed class BackgroundSizeProperty : Property
    {
        private BackgroundSizeProperty() : base("background-size") { }

        internal static readonly BackgroundSizeProperty BackgroundSize = new BackgroundSizeProperty();
    }
}
