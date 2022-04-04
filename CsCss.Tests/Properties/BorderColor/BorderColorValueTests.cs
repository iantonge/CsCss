using CsCss.Properties.BorderColor;
using Xunit;

namespace CsCss.Tests.Properties.BorderColor
{
    public class BorderColorValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BorderColorValue converted = Statics.Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromSingleColorValue()
        {
            BorderColorValue converted = Statics.Red;
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
            BorderColorValue converted = (Statics.Red, 0xFFFFFF);
            Assert.Equal("red #FFFFFF", converted.ToString());
        }

        [Fact]
        public void CanConvertFromTripleColorValue()
        {
            BorderColorValue converted = (Statics.Red, 0xFFFFFF, Statics.Rgb(25.Percent(), 50.Percent(), 75.Percent()));
            Assert.Equal("red #FFFFFF rgb(25%,50%,75%)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromQuadrupleColorValue()
        {
            BorderColorValue converted = (Statics.Red, 0xFFFFFF, Statics.Rgb(25.Percent(), 50.Percent(), 75.Percent()), Statics.Transparent);
            Assert.Equal("red #FFFFFF rgb(25%,50%,75%) transparent", converted.ToString());
        }
    }
}
