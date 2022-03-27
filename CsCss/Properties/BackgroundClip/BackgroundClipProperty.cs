namespace CsCss.Properties.BackgroundClip
{
    public sealed class BackgroundClipProperty : Property
    {
        private BackgroundClipProperty() : base("background-clip") { }

        internal static readonly BackgroundClipProperty BackgroundClip = new BackgroundClipProperty();
    }
}
