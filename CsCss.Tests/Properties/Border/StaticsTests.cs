using CsCss.Properties.Border;
using Xunit;

namespace CsCss.Tests.Properties.Border
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBorder()
        {
            Assert.Equal("border", Keywords.Border.ToString());
            Assert.Equal(typeof(BorderProperty), Keywords.Border.GetType());
        }

        [Fact]
        public void RendersBorderTop()
        {
            Assert.Equal("border-top", BorderTop.ToString());
            Assert.Equal(typeof(BorderProperty), BorderTop.GetType());
        }

        [Fact]
        public void RendersBorderBottom()
        {
            Assert.Equal("border-bottom", BorderBottom.ToString());
            Assert.Equal(typeof(BorderProperty), BorderBottom.GetType());
        }

        [Fact]
        public void RendersBorderLeft()
        {
            Assert.Equal("border-left", BorderLeft.ToString());
            Assert.Equal(typeof(BorderProperty), BorderLeft.GetType());
        }

        [Fact]
        public void RendersBorderRight()
        {
            Assert.Equal("border-right", BorderRight.ToString());
            Assert.Equal(typeof(BorderProperty), BorderRight.GetType());
        }
    }
}
