using CsCss.Values.Text.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Text.Keyword
{
    public class FixedKeywordTests
    {
        [Fact]
        public void RendersFixedKeyword()
        {
            Assert.Equal("fixed", Statics.Fixed.ToString());
            Assert.Equal(typeof(FixedKeyword), Statics.Fixed.GetType());
        }
    }
}
