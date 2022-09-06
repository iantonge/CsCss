using CsCss.Properties.BackgroundAttachment;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundAttachment
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundAttachment()
        {
            Assert.Equal("background-attachment", Keywords.BackgroundAttachment.ToString());
            Assert.Equal(typeof(BackgroundAttachmentProperty), Keywords.BackgroundAttachment.GetType());
        }
    }
}
