using CsCss.Values.Color.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Color.Keyword
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersTransparentKeyword()
        {
            Assert.Equal("transparent", Keywords.Transparent.ToString());
            Assert.Equal(typeof(ColorKeyword), Keywords.Transparent.GetType());
        }

        [Fact]
        public void RendersCurrentColorKeyword()
        {
            Assert.Equal("currentcolor", Keywords.CurrentColor.ToString());
            Assert.Equal(typeof(ColorKeyword), Keywords.CurrentColor.GetType());
        }
    }
}
