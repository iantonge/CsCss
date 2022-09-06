using CsCss.Properties.BackgroundColor;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundColor
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundColor()
        {
            Assert.Equal("background-color", Keywords.BackgroundColor.ToString());
            Assert.Equal(typeof(BackgroundColorProperty), Keywords.BackgroundColor.GetType());
        }
    }
}
