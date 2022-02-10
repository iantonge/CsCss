using CsCss.Properties.BackgroundAttachment;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundAttachment
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundAttachment()
        {
            Assert.Equal("background-attachment", Statics.BackgroundAttachment.ToString());
            Assert.Equal(typeof(BackgroundAttachmentProperty), Statics.BackgroundAttachment.GetType());
        }
    }
}
