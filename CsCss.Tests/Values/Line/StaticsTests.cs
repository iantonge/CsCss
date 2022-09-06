using CsCss.Values.Line;
using Xunit;

namespace CsCss.Tests.Values.Line
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersThinKeyword()
        {
            Assert.Equal("thin", Thin.ToString());
            Assert.Equal(typeof(LineWidthValue), Thin.GetType());
        }

        [Fact]
        public void RendersMediumKeyword()
        {
            Assert.Equal("medium", Medium.ToString());
            Assert.Equal(typeof(LineWidthValue), Medium.GetType());
        }

        [Fact]
        public void RendersThickKeyword()
        {
            Assert.Equal("thick", Thick.ToString());
            Assert.Equal(typeof(LineWidthValue), Thick.GetType());
        }

        [Fact]
        public void RendersHiddenKeyword()
        {
            Assert.Equal("hidden", Hidden.ToString());
            Assert.Equal(typeof(LineStyleValue), Hidden.GetType());
        }

        [Fact]
        public void RendersDottedKeyword()
        {
            Assert.Equal("dotted", Dotted.ToString());
            Assert.Equal(typeof(LineStyleValue), Dotted.GetType());
        }

        [Fact]
        public void RendersDashedKeyword()
        {
            Assert.Equal("dashed", Dashed.ToString());
            Assert.Equal(typeof(LineStyleValue), Dashed.GetType());
        }

        [Fact]
        public void RendersSolidKeyword()
        {
            Assert.Equal("solid", Solid.ToString());
            Assert.Equal(typeof(LineStyleValue), Solid.GetType());
        }

        [Fact]
        public void RendersDoubleKeyword()
        {
            Assert.Equal("double", Double.ToString());
            Assert.Equal(typeof(LineStyleValue), Double.GetType());
        }

        [Fact]
        public void RendersGrooveKeyword()
        {
            Assert.Equal("groove", Groove.ToString());
            Assert.Equal(typeof(LineStyleValue), Groove.GetType());
        }

        [Fact]
        public void RendersRidgeKeyword()
        {
            Assert.Equal("ridge", Ridge.ToString());
            Assert.Equal(typeof(LineStyleValue), Ridge.GetType());
        }

        [Fact]
        public void RendersInsetKeyword()
        {
            Assert.Equal("inset", Inset.ToString());
            Assert.Equal(typeof(LineStyleValue), Inset.GetType());
        }

        [Fact]
        public void RendersOutsetKeyword()
        {
            Assert.Equal("outset", Outset.ToString());
            Assert.Equal(typeof(LineStyleValue), Outset.GetType());
        }
    }
}
