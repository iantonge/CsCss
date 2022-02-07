namespace CsCss.Properties.BackgroundAttachment
{
    public sealed class BackgroundAttachmentProperty : Property
    {
        private BackgroundAttachmentProperty() : base("background-attachment") { }

        public BackgroundAttachmentValue As(params BackgroundAttachmentValue[] values)
        {
            return BackgroundAttachmentValue.With(values);
        }

        internal static readonly BackgroundAttachmentProperty BackgroundAttachment = new BackgroundAttachmentProperty();
    }
}
