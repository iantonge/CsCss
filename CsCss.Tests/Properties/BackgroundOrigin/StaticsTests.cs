using CsCss.Properties.BackgroundOrigin;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundOrigin
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundOrigin()
        {
            Assert.Equal("background-origin", Statics.BackgroundOrigin.ToString());
            Assert.Equal(typeof(BackgroundOriginProperty), Statics.BackgroundOrigin.GetType());
        }
    }
}
