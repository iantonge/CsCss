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
            Assert.Equal("border-box", BorderBox.ToString());
            Assert.Equal(typeof(BoxKeyword), BorderBox.GetType());
        }

        [Fact]
        public void RendersPaddingBoxKeyword()
        {
            Assert.Equal("padding-box", PaddingBox.ToString());
            Assert.Equal(typeof(BoxKeyword), PaddingBox.GetType());
        }

        [Fact]
        public void RendersContentBoxKeyword()
        {
            Assert.Equal("content-box", ContentBox.ToString());
            Assert.Equal(typeof(BoxKeyword), ContentBox.GetType());
        }

        [Fact]
        public void RendersTextKeyword()
        {
            Assert.Equal("text", Keywords.Text.ToString());
            Assert.Equal(typeof(TextKeyword), Keywords.Text.GetType());
        }
    }
}
