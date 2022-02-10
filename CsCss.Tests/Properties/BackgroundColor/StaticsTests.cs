using CsCss.Properties.BackgroundColor;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundColor
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundColor()
        {
            Assert.Equal("background-color", Statics.BackgroundColor.ToString());
            Assert.Equal(typeof(BackgroundColorProperty), Statics.BackgroundColor.GetType());
        }
    }
}
