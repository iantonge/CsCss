using CsCss.Properties.BackgroundSize;
using CsCss.Properties.Border;
using Xunit;

namespace CsCss.Tests.Properties.Border
{
    public class BorderValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BorderValue converted = Statics.Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLineWidthValue()
        {
            BorderValue converted = Statics.Thick;
            Assert.Equal("thick", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthValue()
        {
            BorderValue converted = 10.Px();
            Assert.Equal("10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLineStyleValue()
        {
            BorderValue converted = Statics.Dashed;
            Assert.Equal("dashed", converted.ToString());
        }

        [Fact]
        public void CanConvertFromNoneKeyword()
        {
            BorderValue converted = Statics.None;
            Assert.Equal("none", converted.ToString());
        }

        [Fact]
        public void CanConvertFromColorValue()
        {
            BorderValue converted = Statics.Red;
            Assert.Equal("red", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHexColorValue()
        {
            BorderValue converted = 0xFFFFFF;
            Assert.Equal("#FFFFFF", converted.ToString());
        }

        [Fact]
        public void CanConvertFromWidthStyleTuple()
        {
            BorderValue converted = (10.Px(), Statics.Dashed);
            Assert.Equal("10px dashed", converted.ToString());
        }

        [Fact]
        public void CanConvertFromWidthColorTuple()
        {
            BorderValue converted = (10.Px(), Statics.Red);
            Assert.Equal("10px red", converted.ToString());
        }

        [Fact]
        public void CanConvertFromWidthStyleColorTuple()
        {
            BorderValue converted = (10.Px(), Statics.Dotted, Statics.Red);
            Assert.Equal("10px dotted red", converted.ToString());
        }

        [Fact]
        public void CanConvertFromStyleColorTuple()
        {
            BorderValue converted = (Statics.Dotted, Statics.Red);
            Assert.Equal("dotted red", converted.ToString());
        }
    }
}
