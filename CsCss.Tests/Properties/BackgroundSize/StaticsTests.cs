using CsCss.Properties.BackgroundSize;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundSize
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundRepeat()
        {
            Assert.Equal("background-size", Keywords.BackgroundSize.ToString());
            Assert.Equal(typeof(BackgroundSizeProperty), Keywords.BackgroundSize.GetType());
        }
    }
}
