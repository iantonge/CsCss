using CsCss.Properties.BackgroundAttachment;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundAttachment
{
    public class BackgroundAttachmentValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Initial;
            Assert.Equal("initial", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromFixedKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Fixed;
            Assert.Equal("fixed", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromLocalKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Local;
            Assert.Equal("local", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromScrollKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Scroll;
            Assert.Equal("scroll", backgroundAttachmentValue.ToString());
        }
    }
}
