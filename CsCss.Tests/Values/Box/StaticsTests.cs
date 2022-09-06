using CsCss.Values.Box;
using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.Box
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBorderBoxKeyword()
        {
            Assert.Equal("border-box", Keywords.BorderBox.ToString());
            Assert.Equal(typeof(BoxKeyword), Keywords.BorderBox.GetType());
        }

        [Fact]
        public void RendersPaddingBoxKeyword()
        {
            Assert.Equal("padding-box", Keywords.PaddingBox.ToString());
            Assert.Equal(typeof(BoxKeyword), Keywords.PaddingBox.GetType());
        }

        [Fact]
        public void RendersContentBoxKeyword()
        {
            Assert.Equal("content-box", Keywords.ContentBox.ToString());
            Assert.Equal(typeof(BoxKeyword), Keywords.ContentBox.GetType());
        }

        [Fact]
        public void RendersTextKeyword()
        {
            Assert.Equal("text", Keywords.Text.ToString());
            Assert.Equal(typeof(TextKeyword), Keywords.Text.GetType());
        }
    }
}
