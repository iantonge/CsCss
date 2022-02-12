namespace CsCss.Properties.BackgroundImage
{
    public sealed class BackgroundImageProperty : Property
    {
        private BackgroundImageProperty() : base("background-image") { }

        internal static readonly BackgroundImageProperty BackgroundImage = new BackgroundImageProperty();
    }
}
