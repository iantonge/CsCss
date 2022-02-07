using CsCss.Values;
using CsCss.Values.Text.Global;
using CsCss.Values.Text.Keyword;

namespace CsCss.Properties.BackgroundAttachment
{
    public sealed class BackgroundAttachmentValue : Value
    {
        private BackgroundAttachmentValue(string value) : base(value) { }

        public static implicit operator BackgroundAttachmentValue(GlobalTextValue value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        public static implicit operator BackgroundAttachmentValue(FixedKeywordTextValue value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        public static implicit operator BackgroundAttachmentValue(LocalKeywordTextValue value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        public static implicit operator BackgroundAttachmentValue(ScrollKeywordTextValue value)
        {
            return new BackgroundAttachmentValue(value.ToString());
        }

        internal static BackgroundAttachmentValue With(params BackgroundAttachmentValue[] values)
            => new BackgroundAttachmentValue(string.Join(", ", values.Select(v => v.ToString())));
    }
}
