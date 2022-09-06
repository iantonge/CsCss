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
            Assert.Equal("border-top", Keywords.BorderTop.ToString());
            Assert.Equal(typeof(BorderProperty), Keywords.BorderTop.GetType());
        }

        [Fact]
        public void RendersBorderBottom()
        {
            Assert.Equal("border-bottom", Keywords.BorderBottom.ToString());
            Assert.Equal(typeof(BorderProperty), Keywords.BorderBottom.GetType());
        }

        [Fact]
        public void RendersBorderLeft()
        {
            Assert.Equal("border-left", Keywords.BorderLeft.ToString());
            Assert.Equal(typeof(BorderProperty), Keywords.BorderLeft.GetType());
        }

        [Fact]
        public void RendersBorderRight()
        {
            Assert.Equal("border-right", Keywords.BorderRight.ToString());
            Assert.Equal(typeof(BorderProperty), Keywords.BorderRight.GetType());
        }
    }
}
