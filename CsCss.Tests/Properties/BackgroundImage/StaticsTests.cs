using CsCss.Properties.BackgroundImage;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundImage
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundImage()
        {
            Assert.Equal("background-image", Keywords.BackgroundImage.ToString());
            Assert.Equal(typeof(BackgroundImageProperty), Keywords.BackgroundImage.GetType());
        }
    }
}
