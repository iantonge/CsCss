using CsCss.Properties.BorderColor;
using Xunit;

namespace CsCss.Tests.Properties.BorderColor
{
    public class DirectionalBorderColorValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            DirectionalBorderColorValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromColorValue()
        {
            DirectionalBorderColorValue converted = Red;
            Assert.Equal("red", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHexColorValue()
        {
            DirectionalBorderColorValue converted = 0xFFFFFF;
            Assert.Equal("#FFFFFF", converted.ToString());
        }
    }
}
