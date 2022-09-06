using CsCss.Values.Color.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Color.Keyword
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersTransparentKeyword()
        {
            Assert.Equal("transparent", Transparent.ToString());
            Assert.Equal(typeof(ColorKeyword), Transparent.GetType());
        }

        [Fact]
        public void RendersCurrentColorKeyword()
        {
            Assert.Equal("currentcolor", CurrentColor.ToString());
            Assert.Equal(typeof(ColorKeyword), CurrentColor.GetType());
        }
    }
}
