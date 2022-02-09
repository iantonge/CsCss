using CsCss.Values.Text.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Text.Keyword
{
    public class AutoKeywordTests
    {
        [Fact]
        public void RendersAutoKeyword()
        {
            Assert.Equal("auto", Statics.Auto.ToString());
            Assert.Equal(typeof(AutoKeyword), Statics.Auto.GetType());
        }
    }
}
