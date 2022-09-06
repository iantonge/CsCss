using CsCss.Properties.BorderColor;
using Xunit;

namespace CsCss.Tests.Properties.BorderColor
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBorder()
        {
            Assert.Equal("border-color", Keywords.BorderColor.ToString());
            Assert.Equal(typeof(BorderColorProperty), Keywords.BorderColor.GetType());
        }

        [Fact]
        public void RendersBorderTop()
        {
            Assert.Equal("border-top-color", BorderTopColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), BorderTopColor.GetType());
        }

        [Fact]
        public void RendersBorderBottom()
        {
            Assert.Equal("border-bottom-color", BorderBottomColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), BorderBottomColor.GetType());
        }

        [Fact]
        public void RendersBorderLeft()
        {
            Assert.Equal("border-left-color", BorderLeftColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), BorderLeftColor.GetType());
        }

        [Fact]
        public void RendersBorderRight()
        {
            Assert.Equal("border-right-color", BorderRightColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), BorderRightColor.GetType());
        }
    }
}
