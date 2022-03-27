using CsCss.Properties.BackgroundPosition;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundPosition
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundPosition()
        {
            Assert.Equal("background-position", Statics.BackgroundPosition.ToString());
            Assert.Equal(typeof(BackgroundPositionProperty), Statics.BackgroundPosition.GetType());
        }
    }
}
