using CsCss.Properties.Height;
using Xunit;

namespace CsCss.Tests.Properties.Height
{
    public class HeightValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            HeightValue heightValue = Statics.Initial;
            Assert.Equal("initial", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromAutoKeyword()
        {
            HeightValue heightValue = Statics.Auto;
            Assert.Equal("auto", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromFitContentKeyword()
        {
            HeightValue heightValue = Statics.FitContent();
            Assert.Equal("fit-content", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromMaxContentKeyword()
        {
            HeightValue heightValue = Statics.MaxContent;
            Assert.Equal("max-content", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromMinContentKeyword()
        {
            HeightValue heightValue = Statics.MinContent;
            Assert.Equal("min-content", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromFitContentValue()
        {
            HeightValue heightValue = Statics.FitContent(10.Deg());
            Assert.Equal("fit-content(10deg)", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromPercentageValue()
        {
            HeightValue heightValue = 10.Percent();
            Assert.Equal("10%", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromLengthValue()
        {
            HeightValue heightValue = 10.Px();
            Assert.Equal("10px", heightValue.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentageValue()
        {
            HeightValue heightValue = Statics.Calc(10.Px() - 5.Percent());
            Assert.Equal("calc(10px - 5%)", heightValue.ToString());
        }
    }
}
