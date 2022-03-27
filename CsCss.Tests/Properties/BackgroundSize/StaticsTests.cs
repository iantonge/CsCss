using CsCss.Properties.BackgroundSize;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundSize
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundRepeat()
        {
            Assert.Equal("background-size", Statics.BackgroundSize.ToString());
            Assert.Equal(typeof(BackgroundSizeProperty), Statics.BackgroundSize.GetType());
        }
    }
}
