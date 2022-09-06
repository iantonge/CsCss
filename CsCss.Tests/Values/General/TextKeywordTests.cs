using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class TextKeywordTests
    {
        [Fact]
        public void RendersTextKeyword()
        {
            Assert.Equal("text", Keywords.Text.ToString());
            Assert.Equal(typeof(TextKeyword), Keywords.Text.GetType());
        }
    }
}
