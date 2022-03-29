using CsCss.Properties.Border;
using Xunit;

namespace CsCss.Tests.Properties.Border
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBorder()
        {
            Assert.Equal("border", Statics.Border.ToString());
            Assert.Equal(typeof(BorderProperty), Statics.Border.GetType());
        }
    }
}
