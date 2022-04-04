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

        [Fact]
        public void RendersBorderTop()
        {
            Assert.Equal("border-top", Statics.BorderTop.ToString());
            Assert.Equal(typeof(BorderProperty), Statics.BorderTop.GetType());
        }

        [Fact]
        public void RendersBorderBottom()
        {
            Assert.Equal("border-bottom", Statics.BorderBottom.ToString());
            Assert.Equal(typeof(BorderProperty), Statics.BorderBottom.GetType());
        }

        [Fact]
        public void RendersBorderLeft()
        {
            Assert.Equal("border-left", Statics.BorderLeft.ToString());
            Assert.Equal(typeof(BorderProperty), Statics.BorderLeft.GetType());
        }

        [Fact]
        public void RendersBorderRight()
        {
            Assert.Equal("border-right", Statics.BorderRight.ToString());
            Assert.Equal(typeof(BorderProperty), Statics.BorderRight.GetType());
        }
    }
}
