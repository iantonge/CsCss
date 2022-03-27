using CsCss.Properties.BackgroundClip;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundClip
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundRepeat()
        {
            Assert.Equal("background-clip", Statics.BackgroundClip.ToString());
            Assert.Equal(typeof(BackgroundClipProperty), Statics.BackgroundClip.GetType());
        }
    }
}
