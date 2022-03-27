using CsCss.Properties.BackgroundImage;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundImage
{
    public class BackgroundImageValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundImageValue backgroundImageValue = Statics.Initial;
            Assert.Equal("initial", backgroundImageValue.ToString());
        }

        [Fact]
        public void CanConvertFromNoneKeyword()
        {
            BackgroundImageValue backgroundImageValue = Statics.None;
            Assert.Equal("none", backgroundImageValue.ToString());
        }

        [Fact]
        public void CanConvertFromUrl()
        {
            BackgroundImageValue backgroundImageValue = Statics.Url("path");
            Assert.Equal("url('path')", backgroundImageValue.ToString());
        }

        [Fact]
        public void CanConvertFromGradient()
        {
            BackgroundImageValue backgroundImageValue = Statics.BuildLinearGradient()
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Blue)
                .Build();
            Assert.Equal("linear-gradient(red,blue)", backgroundImageValue.ToString());
        }
    }
}
