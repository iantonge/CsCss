namespace CsCss.Properties.BackgroundAttachment
{
    public sealed class BackgroundAttachmentProperty : Property
    {
        private BackgroundAttachmentProperty() : base("background-attachment") { }

        internal static readonly BackgroundAttachmentProperty BackgroundAttachment = new BackgroundAttachmentProperty();
    }
}
