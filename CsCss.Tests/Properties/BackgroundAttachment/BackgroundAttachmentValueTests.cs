using CsCss.Properties.BackgroundAttachment;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundAttachment
{
    public class BackgroundAttachmentValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Keywords.Initial;
            Assert.Equal("initial", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromFixedKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Keywords.Fixed;
            Assert.Equal("fixed", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromLocalKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Keywords.Local;
            Assert.Equal("local", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromScrollKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Keywords.Scroll;
            Assert.Equal("scroll", backgroundAttachmentValue.ToString());
        }
    }
}
