using CsCss.Properties.BackgroundPosition;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundPosition
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundPosition()
        {
            Assert.Equal("background-position", Keywords.BackgroundPosition.ToString());
            Assert.Equal(typeof(BackgroundPositionProperty), Keywords.BackgroundPosition.GetType());
        }
    }
}
