using CsCss.Values.Color.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Color.Keyword
{
    public class ColorKeywordTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            ColorKeyword colorKeyword = Statics.Unset;
            Assert.Equal("unset", colorKeyword.ToString());
        }
    }
}
