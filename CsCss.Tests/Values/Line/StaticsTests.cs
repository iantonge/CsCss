using CsCss.Values.Line;
using Xunit;

namespace CsCss.Tests.Values.Line
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersThinKeyword()
        {
            Assert.Equal("thin", Keywords.Thin.ToString());
            Assert.Equal(typeof(LineWidthValue), Keywords.Thin.GetType());
        }

        [Fact]
        public void RendersMediumKeyword()
        {
            Assert.Equal("medium", Keywords.Medium.ToString());
            Assert.Equal(typeof(LineWidthValue), Keywords.Medium.GetType());
        }

        [Fact]
        public void RendersThickKeyword()
        {
            Assert.Equal("thick", Keywords.Thick.ToString());
            Assert.Equal(typeof(LineWidthValue), Keywords.Thick.GetType());
        }

        [Fact]
        public void RendersHiddenKeyword()
        {
            Assert.Equal("hidden", Keywords.Hidden.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Hidden.GetType());
        }

        [Fact]
        public void RendersDottedKeyword()
        {
            Assert.Equal("dotted", Keywords.Dotted.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Dotted.GetType());
        }

        [Fact]
        public void RendersDashedKeyword()
        {
            Assert.Equal("dashed", Keywords.Dashed.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Dashed.GetType());
        }

        [Fact]
        public void RendersSolidKeyword()
        {
            Assert.Equal("solid", Keywords.Solid.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Solid.GetType());
        }

        [Fact]
        public void RendersDoubleKeyword()
        {
            Assert.Equal("double", Keywords.Double.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Double.GetType());
        }

        [Fact]
        public void RendersGrooveKeyword()
        {
            Assert.Equal("groove", Keywords.Groove.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Groove.GetType());
        }

        [Fact]
        public void RendersRidgeKeyword()
        {
            Assert.Equal("ridge", Keywords.Ridge.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Ridge.GetType());
        }

        [Fact]
        public void RendersInsetKeyword()
        {
            Assert.Equal("inset", Keywords.Inset.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Inset.GetType());
        }

        [Fact]
        public void RendersOutsetKeyword()
        {
            Assert.Equal("outset", Keywords.Outset.ToString());
            Assert.Equal(typeof(LineStyleValue), Keywords.Outset.GetType());
        }
    }
}
