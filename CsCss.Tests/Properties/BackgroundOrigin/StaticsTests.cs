using CsCss.Properties.BackgroundOrigin;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundOrigin
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundOrigin()
        {
            Assert.Equal("background-origin", Keywords.BackgroundOrigin.ToString());
            Assert.Equal(typeof(BackgroundOriginProperty), Keywords.BackgroundOrigin.GetType());
        }
    }
}
