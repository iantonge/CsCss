using CsCss.Values.Color.Function;
using Xunit;

namespace CsCss.Tests.Values.Color.Function
{
    public class StaticsTests
    {
        [Fact]
        public void RendersRgbColor()
        {
            var result = Statics.Rgb(180, 50.Percent(), 0.5);
            Assert.Equal("rgb(180,50%,0.5)", result.ToString());
            Assert.Equal(typeof(RgbValue), result.GetType());
        }

        [Fact]
        public void RendersRgbaColor()
        {
            var result = Statics.Rgba(180, 50.Percent(), 0.5, 0.85);
            Assert.Equal("rgba(180,50%,0.5,0.85)", result.ToString());
            Assert.Equal(typeof(RgbaValue), result.GetType());
        }

        [Fact]
        public void RendersHslColor()
        {
            var result = Statics.Hsl(90.Deg(), 25.Percent(), 50.Percent());
            Assert.Equal("hsl(90deg,25%,50%)", result.ToString());
            Assert.Equal(typeof(HslValue), result.GetType());
        }

        [Fact]
        public void RendersHslaColor()
        {
            var result = Statics.Hsla(90.Deg(), 25.Percent(), 50.Percent(), 0.75);
            Assert.Equal("hsla(90deg,25%,50%,0.75)", result.ToString());
            Assert.Equal(typeof(HslaValue), result.GetType());
        }

        [Fact]
        public void RendersHwbColor()
        {
            var result = Statics.Hwb(90.Deg(), 25.Percent(), 50.Percent());
            Assert.Equal("hwb(90deg 25% 50%)", result.ToString());
            Assert.Equal(typeof(HwbValue), result.GetType());
        }

        [Fact]
        public void RendersHwbColorWithAlpha()
        {
            var result = Statics.Hwb(90.Deg(), 25.Percent(), 50.Percent(), 0.75);
            Assert.Equal("hwb(90deg 25% 50% / 0.75)", result.ToString());
            Assert.Equal(typeof(HwbValue), result.GetType());
        }
    }
}
