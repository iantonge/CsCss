using CsCss.Values;
using CsCss.Values.Text.Global;
using CsCss.Values.Text.Keyword;

namespace CsCss.Properties.BackgroundAttachment
{
    public sealed class BackgroundAttachmentValue : Value
    {
        private BackgroundAttachmentValue(string value) : base(value) { }

        public static implicit operator BackgroundAttachmentValue(GlobalKeyword value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        public static implicit operator BackgroundAttachmentValue(FixedKeyword value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        public static implicit operator BackgroundAttachmentValue(LocalKeyword value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        public static implicit operator BackgroundAttachmentValue(ScrollKeyword value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        public static implicit operator BackgroundAttachmentValue(BackgroundAttachmentValue[] values)
        {
            return new BackgroundAttachmentValue(string.Join(", ", values.Select(v => v.ToString())));
        }
    }
}
