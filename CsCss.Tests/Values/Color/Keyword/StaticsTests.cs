using CsCss.Values.Color.Keyword;
using Xunit;

namespace CsCss.Tests.Values.Color.Keyword
{
    public class StaticsTests
    {
        [Fact]
        public void RendersTransparentKeyword()
        {
            Assert.Equal("transparent", Statics.Transparent.ToString());
            Assert.Equal(typeof(ColorKeyword), Statics.Transparent.GetType());
        }

        [Fact]
        public void RendersCurrentColorKeyword()
        {
            Assert.Equal("currentcolor", Statics.CurrentColor.ToString());
            Assert.Equal(typeof(ColorKeyword), Statics.CurrentColor.GetType());
        }
    }
}
