using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class ScrollKeywordTests
    {
        [Fact]
        public void RendersScrollKeyword()
        {
            Assert.Equal("scroll", Keywords.Scroll.ToString());
            Assert.Equal(typeof(ScrollKeyword), Keywords.Scroll.GetType());
        }
    }
}
