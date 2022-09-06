using CsCss.Properties.AccentColor;
using Xunit;

namespace CsCss.Tests.Properties.AccentColor
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersAccentColor()
        {
            Assert.Equal("accent-color", Keywords.AccentColor.ToString());
            Assert.Equal(typeof(AccentColorProperty), Keywords.AccentColor.GetType());
        }
    }
}
