using CsCss.Properties.BackgroundImage;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundImage
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundImage()
        {
            Assert.Equal("background-image", Statics.BackgroundImage.ToString());
            Assert.Equal(typeof(BackgroundImageProperty), Statics.BackgroundImage.GetType());
        }
    }
}
