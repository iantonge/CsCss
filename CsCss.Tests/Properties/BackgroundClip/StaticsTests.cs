using CsCss.Properties.BackgroundClip;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundClip
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundRepeat()
        {
            Assert.Equal("background-clip", Keywords.BackgroundClip.ToString());
            Assert.Equal(typeof(BackgroundClipProperty), Keywords.BackgroundClip.GetType());
        }
    }
}
