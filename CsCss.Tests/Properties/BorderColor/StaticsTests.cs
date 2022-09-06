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
            Assert.Equal("border-top-color", Keywords.BorderTopColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), Keywords.BorderTopColor.GetType());
        }

        [Fact]
        public void RendersBorderBottom()
        {
            Assert.Equal("border-bottom-color", Keywords.BorderBottomColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), Keywords.BorderBottomColor.GetType());
        }

        [Fact]
        public void RendersBorderLeft()
        {
            Assert.Equal("border-left-color", Keywords.BorderLeftColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), Keywords.BorderLeftColor.GetType());
        }

        [Fact]
        public void RendersBorderRight()
        {
            Assert.Equal("border-right-color", Keywords.BorderRightColor.ToString());
            Assert.Equal(typeof(DirectionalBorderColorProperty), Keywords.BorderRightColor.GetType());
        }
    }
}
