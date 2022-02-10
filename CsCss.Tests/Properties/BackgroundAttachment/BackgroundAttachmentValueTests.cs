using CsCss.Properties.BackgroundAttachment;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundAttachment
{
    public class BackgroundAttachmentValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Statics.Initial;
            Assert.Equal("initial", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromFixedKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Statics.Fixed;
            Assert.Equal("fixed", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromLocalKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Statics.Local;
            Assert.Equal("local", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromScrollKeyword()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = Statics.Scroll;
            Assert.Equal("scroll", backgroundAttachmentValue.ToString());
        }

        [Fact]
        public void CanConvertFromArray()
        {
            BackgroundAttachmentValue backgroundAttachmentValue = 
                new BackgroundAttachmentValue[] { Statics.Fixed, Statics.Local, Statics.Scroll };
            Assert.Equal("fixed, local, scroll", backgroundAttachmentValue.ToString());
        }
    }
}
