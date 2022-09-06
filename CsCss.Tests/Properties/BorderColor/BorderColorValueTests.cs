using CsCss.Properties.BorderColor;
using Xunit;

namespace CsCss.Tests.Properties.BorderColor
{
    public class BorderColorValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BorderColorValue converted = Keywords.Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromSingleColorValue()
        {
            BorderColorValue converted = Keywords.Red;
            Assert.Equal("red", converted.ToString());
        }

        [Fact]
        public void CanConvertFromSingleHexColorValue()
        {
            BorderColorValue converted = 0xFFFFFF;
            Assert.Equal("#FFFFFF", converted.ToString());
        }

        [Fact]
        public void CanConvertFromDoubleColorValue()
        {
            BorderColorValue converted = (Keywords.Red, 0xFFFFFF);
            Assert.Equal("red #FFFFFF", converted.ToString());
        }

        [Fact]
        public void CanConvertFromTripleColorValue()
        {
            BorderColorValue converted = (Keywords.Red, 0xFFFFFF, Functions.Rgb(25.Percent(), 50.Percent(), 75.Percent()));
            Assert.Equal("red #FFFFFF rgb(25%,50%,75%)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromQuadrupleColorValue()
        {
            BorderColorValue converted = (Keywords.Red, 0xFFFFFF, Functions.Rgb(25.Percent(), 50.Percent(), 75.Percent()), Keywords.Transparent);
            Assert.Equal("red #FFFFFF rgb(25%,50%,75%) transparent", converted.ToString());
        }
    }
}
