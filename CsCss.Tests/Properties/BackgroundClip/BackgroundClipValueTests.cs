using CsCss.Properties.BackgroundClip;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundClip
{
    public class BackgroundClipValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundClipValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBoxKeyword()
        {
            BackgroundClipValue converted = ContentBox;
            Assert.Equal("content-box", converted.ToString());
        }

        [Fact]
        public void CanConvertFromTextKeyword()
        {
            BackgroundClipValue converted = Text;
            Assert.Equal("text", converted.ToString());
        }
    }
}
