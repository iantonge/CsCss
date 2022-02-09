using CsCss.Values.Text.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Text.Keyword
{
    public class ScrollKeywordTests
    {
        [Fact]
        public void RendersScrollKeyword()
        {
            Assert.Equal("scroll", Statics.Scroll.ToString());
            Assert.Equal(typeof(ScrollKeyword), Statics.Scroll.GetType());
        }
    }
}
