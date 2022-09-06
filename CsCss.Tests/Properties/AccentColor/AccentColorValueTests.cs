using CsCss.Properties.AccentColor;
using Xunit;

namespace CsCss.Tests.Properties.AccentColor
{
    public class AccentColorValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            AccentColorValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }
        [Fact]
        public void CanConvertFromAutoKeyword()
        {
            AccentColorValue converted = Auto;
            Assert.Equal("auto", converted.ToString());
        }

        [Fact]
        public void CanConvertColor()
        {
            AccentColorValue converted = Red;
            Assert.Equal("red", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHex()
        {
            AccentColorValue converted = 0xFFFFFF;
            Assert.Equal("#FFFFFF", converted.ToString());
        }
    }
}
