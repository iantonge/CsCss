using CsCss.Properties.BorderColor;
using Xunit;

namespace CsCss.Tests.Properties.BorderColor
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBorder()
        {
            Assert.Equal("border-color", Statics.BorderColor.ToString());
            Assert.Equal(typeof(BorderColorProperty), Statics.BorderColor.GetType());
        }

        [Fact]
        public void RendersBorderTop()
        {
            Assert.Equal("border-top-color", Statics.BorderTopColor.ToString());
            Assert.Equal(typeof(BorderColorProperty), Statics.BorderTopColor.GetType());
        }

        [Fact]
        public void RendersBorderBottom()
        {
            Assert.Equal("border-bottom-color", Statics.BorderBottomColor.ToString());
            Assert.Equal(typeof(BorderColorProperty), Statics.BorderBottomColor.GetType());
        }

        [Fact]
        public void RendersBorderLeft()
        {
            Assert.Equal("border-left-color", Statics.BorderLeftColor.ToString());
            Assert.Equal(typeof(BorderColorProperty), Statics.BorderLeftColor.GetType());
        }

        [Fact]
        public void RendersBorderRight()
        {
            Assert.Equal("border-right-color", Statics.BorderRightColor.ToString());
            Assert.Equal(typeof(BorderColorProperty), Statics.BorderRightColor.GetType());
        }
    }
}
