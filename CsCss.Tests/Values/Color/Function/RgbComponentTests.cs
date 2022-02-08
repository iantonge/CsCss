using CsCss.Values.Color.Function;
using Xunit;

namespace CsCss.Tests.Values.Color.Function
{
    public class RgbComponentTests
    {
        [Fact]
        public void CanConvertFromInt()
        {
            RgbComponent rgbComponent = 2;
            Assert.Equal("2", rgbComponent.ToString());
        }

        [Fact]
        public void CanConvertFromDouble()
        {
            RgbComponent rgbComponent = 2.5;
            Assert.Equal("2.5", rgbComponent.ToString());
        }


        [Fact]
        public void CanConvertFromPercentageValue()
        {
            var percentage = 2.5.Percent();
            RgbComponent rgbComponent = percentage;
            Assert.Equal("2.5%", rgbComponent.ToString());
        }
    }
}
