using CsCss.Properties.BackgroundSize;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundSize
{
    public class BackgroundSizeValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundSizeValue converted = Keywords.Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromAutoKeyword()
        {
            BackgroundSizeValue converted = Keywords.Auto;
            Assert.Equal("auto", converted.ToString());
        }

        [Fact]
        public void CanConvertFromContainKeyword()
        {
            BackgroundSizeValue converted = Keywords.Contain;
            Assert.Equal("contain", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCoverKeyword()
        {
            BackgroundSizeValue converted = Keywords.Cover;
            Assert.Equal("cover", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLength()
        {
            BackgroundSizeValue converted = 10.Px();
            Assert.Equal("10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentage()
        {
            BackgroundSizeValue converted = 10.Percent();
            Assert.Equal("10%", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentage()
        {
            BackgroundSizeValue converted = Functions.Calc(10.Percent() + 10.Px());
            Assert.Equal("calc(10% + 10px)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromAutoTuple()
        {
            BackgroundSizeValue converted = (Keywords.Auto, Keywords.Auto);
            Assert.Equal("auto auto", converted.ToString());
        }

        [Fact]
        public void CanConvertFromAutoLengthPercentageTuple()
        {
            BackgroundSizeValue length = (Keywords.Auto, 10.Px());
            Assert.Equal("auto 10px", length.ToString());

            BackgroundSizeValue percentage = (Keywords.Auto, 10.Percent());
            Assert.Equal("auto 10%", percentage.ToString());

            BackgroundSizeValue lengthPercentage = (Keywords.Auto, Functions.Calc(10.Percent() + 10.Px()));
            Assert.Equal("auto calc(10% + 10px)", lengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentageTuple()
        {
            BackgroundSizeValue length_length = (10.Px(), 10.Px());
            Assert.Equal("10px 10px", length_length.ToString());

            BackgroundSizeValue length_percentage = (10.Px(), 10.Percent());
            Assert.Equal("10px 10%", length_percentage.ToString());

            BackgroundSizeValue length_lengthPercentage = (10.Px(), Functions.Calc(10.Percent() + 10.Px()));
            Assert.Equal("10px calc(10% + 10px)", length_lengthPercentage.ToString());

            BackgroundSizeValue percentage_length = (10.Percent(), 10.Px());
            Assert.Equal("10% 10px", percentage_length.ToString());

            BackgroundSizeValue percentage_percentage = (10.Percent(), 10.Percent());
            Assert.Equal("10% 10%", percentage_percentage.ToString());

            BackgroundSizeValue percentage_lengthPercentage = (10.Percent(), Functions.Calc(10.Percent() + 10.Px()));
            Assert.Equal("10% calc(10% + 10px)", percentage_lengthPercentage.ToString());

            BackgroundSizeValue lengthPercentage_length = (Functions.Calc(10.Percent() + 10.Px()), 10.Px());
            Assert.Equal("calc(10% + 10px) 10px", lengthPercentage_length.ToString());

            BackgroundSizeValue lengthPercentage_percentage = (Functions.Calc(10.Percent() + 10.Px()), 10.Percent());
            Assert.Equal("calc(10% + 10px) 10%", lengthPercentage_percentage.ToString());

            BackgroundSizeValue lengthPercentage_lengthPercentage = (Functions.Calc(10.Percent() + 10.Px()), Functions.Calc(10.Percent() + 10.Px()));
            Assert.Equal("calc(10% + 10px) calc(10% + 10px)", lengthPercentage_lengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentageAutoTuple()
        {
            BackgroundSizeValue length = (10.Px(), Keywords.Auto);
            Assert.Equal("10px auto", length.ToString());

            BackgroundSizeValue percentage = (10.Percent(), Keywords.Auto);
            Assert.Equal("10% auto", percentage.ToString());

            BackgroundSizeValue lengthPercentage = (Functions.Calc(10.Percent() + 10.Px()), Keywords.Auto);
            Assert.Equal("calc(10% + 10px) auto", lengthPercentage.ToString());
        }
    }
}
