using CsCss.Properties.Height;
using Xunit;

namespace CsCss.Tests.Properties.Height
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundAttachment()
        {
            Assert.Equal("height", Keywords.Height.ToString());
            Assert.Equal(typeof(HeightProperty), Keywords.Height.GetType());
        }
    }
}
