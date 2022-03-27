using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class TextKeywordTests
    {
        [Fact]
        public void RendersTextKeyword()
        {
            Assert.Equal("text", Statics.Text.ToString());
            Assert.Equal(typeof(TextKeyword), Statics.Text.GetType());
        }
    }
}
