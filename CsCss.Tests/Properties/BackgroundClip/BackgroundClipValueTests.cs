using CsCss.Properties.BackgroundClip;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundClip
{
    public class BackgroundClipValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundClipValue converted = Statics.Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromBoxKeyword()
        {
            BackgroundClipValue converted = Statics.ContentBox;
            Assert.Equal("content-box", converted.ToString());
        }
    }
}
