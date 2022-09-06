using CsCss.Properties.BackgroundClip;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundClip
{
    public class BackgroundClipValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundClipValue converted = Keywords.Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBoxKeyword()
        {
            BackgroundClipValue converted = Keywords.ContentBox;
            Assert.Equal("content-box", converted.ToString());
        }

        [Fact]
        public void CanConvertFromTextKeyword()
        {
            BackgroundClipValue converted = Keywords.Text;
            Assert.Equal("text", converted.ToString());
        }
    }
}
