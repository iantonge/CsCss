using CsCss.Values.Color;
using Xunit;

namespace CsCss.Tests.Values.Color
{
    public class ColorValueTests
    {
        [Fact]
        public void CanConvertFromHex()
        {
            ColorValue colorValue = 0xFFFFFF;
            Assert.Equal("#FFFFFF", colorValue.ToString());
        }
    }
}
