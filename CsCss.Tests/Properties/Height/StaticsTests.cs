using CsCss.Properties.Height;
using Xunit;

namespace CsCss.Tests.Properties.Height
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundAttachment()
        {
            Assert.Equal("height", Statics.Height.ToString());
            Assert.Equal(typeof(HeightProperty), Statics.Height.GetType());
        }
    }
}
