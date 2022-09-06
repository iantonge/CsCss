using CsCss.Properties.BackgroundImage;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundImage
{
    public class BackgroundImageValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundImageValue backgroundImageValue = Keywords.Initial;
            Assert.Equal("initial", backgroundImageValue.ToString());
        }

        [Fact]
        public void CanConvertFromNoneKeyword()
        {
            BackgroundImageValue backgroundImageValue = Keywords.None;
            Assert.Equal("none", backgroundImageValue.ToString());
        }

        [Fact]
        public void CanConvertFromUrl()
        {
            BackgroundImageValue backgroundImageValue = Functions.Url("path");
            Assert.Equal("url('path')", backgroundImageValue.ToString());
        }

        [Fact]
        public void CanConvertFromGradient()
        {
            BackgroundImageValue backgroundImageValue = Functions.BuildLinearGradient()
                .WithColorStop(Keywords.Red)
                .WithColorStop(Keywords.Blue)
                .Build();
            Assert.Equal("linear-gradient(red,blue)", backgroundImageValue.ToString());
        }
    }
}
