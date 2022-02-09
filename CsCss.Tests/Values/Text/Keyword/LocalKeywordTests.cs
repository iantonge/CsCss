using CsCss.Values.Text.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Text.Keyword
{
    public class LocalKeywordTests
    {
        [Fact]
        public void RendersLocalKeyword()
        {
            Assert.Equal("local", Statics.Local.ToString());
            Assert.Equal(typeof(LocalKeyword), Statics.Local.GetType());
        }
    }
}
