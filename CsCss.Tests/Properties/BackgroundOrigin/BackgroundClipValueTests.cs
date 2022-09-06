using CsCss.Properties.BackgroundOrigin;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundOrigin
{
    public class BackgroundOriginValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundOriginValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBoxKeyword()
        {
            BackgroundOriginValue converted = ContentBox;
            Assert.Equal("content-box", converted.ToString());
        }
    }
}
