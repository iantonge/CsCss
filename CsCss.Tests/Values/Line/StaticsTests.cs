using CsCss.Values.Line;
using Xunit;

namespace CsCss.Tests.Values.Line
{
    public class StaticsTests
    {
        [Fact]
        public void RendersThinKeyword()
        {
            Assert.Equal("thin", Statics.Thin.ToString());
            Assert.Equal(typeof(LineWidthValue), Statics.Thin.GetType());
        }

        [Fact]
        public void RendersMediumKeyword()
        {
            Assert.Equal("medium", Statics.Medium.ToString());
            Assert.Equal(typeof(LineWidthValue), Statics.Medium.GetType());
        }

        [Fact]
        public void RendersThickKeyword()
        {
            Assert.Equal("thick", Statics.Thick.ToString());
            Assert.Equal(typeof(LineWidthValue), Statics.Thick.GetType());
        }

        [Fact]
        public void RendersHiddenKeyword()
        {
            Assert.Equal("hidden", Statics.Hidden.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Hidden.GetType());
        }

        [Fact]
        public void RendersDottedKeyword()
        {
            Assert.Equal("dotted", Statics.Dotted.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Dotted.GetType());
        }

        [Fact]
        public void RendersDashedKeyword()
        {
            Assert.Equal("dashed", Statics.Dashed.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Dashed.GetType());
        }

        [Fact]
        public void RendersSolidKeyword()
        {
            Assert.Equal("solid", Statics.Solid.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Solid.GetType());
        }

        [Fact]
        public void RendersDoubleKeyword()
        {
            Assert.Equal("double", Statics.Double.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Double.GetType());
        }

        [Fact]
        public void RendersGrooveKeyword()
        {
            Assert.Equal("groove", Statics.Groove.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Groove.GetType());
        }

        [Fact]
        public void RendersRidgeKeyword()
        {
            Assert.Equal("ridge", Statics.Ridge.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Ridge.GetType());
        }

        [Fact]
        public void RendersInsetKeyword()
        {
            Assert.Equal("inset", Statics.Inset.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Inset.GetType());
        }

        [Fact]
        public void RendersOutsetKeyword()
        {
            Assert.Equal("outset", Statics.Outset.ToString());
            Assert.Equal(typeof(LineStyleValue), Statics.Outset.GetType());
        }
    }
}
