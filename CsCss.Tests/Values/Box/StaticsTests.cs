using CsCss.Values.Box;
using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.Box
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBorderBoxKeyword()
        {
            Assert.Equal("border-box", Statics.BorderBox.ToString());
            Assert.Equal(typeof(BoxKeyword), Statics.BorderBox.GetType());
        }

        [Fact]
        public void RendersPaddingBoxKeyword()
        {
            Assert.Equal("padding-box", Statics.PaddingBox.ToString());
            Assert.Equal(typeof(BoxKeyword), Statics.PaddingBox.GetType());
        }

        [Fact]
        public void RendersContentBoxKeyword()
        {
            Assert.Equal("content-box", Statics.ContentBox.ToString());
            Assert.Equal(typeof(BoxKeyword), Statics.ContentBox.GetType());
        }

        [Fact]
        public void RendersTextKeyword()
        {
            Assert.Equal("text", Statics.Text.ToString());
            Assert.Equal(typeof(TextKeyword), Statics.Text.GetType());
        }
    }
}
