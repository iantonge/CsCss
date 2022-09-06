using CsCss.Properties.BackgroundOrigin;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundOrigin
{
    public class BackgroundOriginValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundOriginValue converted = Keywords.Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBoxKeyword()
        {
            BackgroundOriginValue converted = Keywords.ContentBox;
            Assert.Equal("content-box", converted.ToString());
        }
    }
}
