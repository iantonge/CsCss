using CsCss.Properties.BackgroundAttachment;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundAttachmentValue this[BackgroundAttachmentProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
