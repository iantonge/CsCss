using CsCss.Properties.BackgroundPosition;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundPosition
{
    public class BackgroundPositionValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundPositionValue converted = Initial;
            Assert.Equal("initial", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLength()
        {
            BackgroundPositionValue converted = 10.Px();
            Assert.Equal("10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentage()
        {
            BackgroundPositionValue converted = 10.Percent();
            Assert.Equal("10%", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentage()
        {
            BackgroundPositionValue converted = Functions.Calc(10.Percent() - 10.Px());
            Assert.Equal("calc(10% - 10px)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthAndLength()
        {
            BackgroundPositionValue converted = (10.Px(), 10.Px());
            Assert.Equal("10px 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthAndPercentage()
        {
            BackgroundPositionValue converted = (10.Px(), 10.Percent());
            Assert.Equal("10px 10%", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthAndLengthPercentage()
        {
            BackgroundPositionValue converted = (10.Px(), Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("10px calc(10% - 10px)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentageAndLength()
        {
            BackgroundPositionValue converted = (10.Percent(), 10.Px());
            Assert.Equal("10% 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentageAndPercentage()
        {
            BackgroundPositionValue converted = (10.Percent(), 10.Percent());
            Assert.Equal("10% 10%", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPercentageAndLengthPercentage()
        {
            BackgroundPositionValue converted = (10.Percent(), Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("10% calc(10% - 10px)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentageAndLength()
        {
            BackgroundPositionValue converted = (Functions.Calc(10.Percent() - 10.Px()), 10.Px());
            Assert.Equal("calc(10% - 10px) 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentageAndPercentage()
        {
            BackgroundPositionValue converted = (Functions.Calc(10.Percent() - 10.Px()), 10.Percent());
            Assert.Equal("calc(10% - 10px) 10%", converted.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentageAndLengthPercentage()
        {
            BackgroundPositionValue converted = (Functions.Calc(10.Percent() - 10.Px()), Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("calc(10% - 10px) calc(10% - 10px)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromPosition()
        {
            BackgroundPositionValue converted = Left;
            Assert.Equal("left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndVertical()
        {
            BackgroundPositionValue converted = (Left, Top);
            Assert.Equal("left top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndHorizontal()
        {
            BackgroundPositionValue converted = (Top, Left);
            Assert.Equal("top left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndVertical()
        {
            BackgroundPositionValue converted = (Center, Top);
            Assert.Equal("center top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndHorizontal()
        {
            BackgroundPositionValue converted = (Center, Left);
            Assert.Equal("center left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndCenter()
        {
            BackgroundPositionValue converted = (Left, Center);
            Assert.Equal("left center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndCenter()
        {
            BackgroundPositionValue converted = (Top, Center);
            Assert.Equal("top center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndCenter()
        {
            BackgroundPositionValue converted = (Center, Center);
            Assert.Equal("center center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVertical()
        {
            BackgroundPositionValue converted = (Left, 10.Px(), Top);
            Assert.Equal("left 10px top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndHorizontal()
        {
            BackgroundPositionValue converted = (Top, 10.Px(), Left);
            Assert.Equal("top 10px left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndCenter()
        {
            BackgroundPositionValue converted = (Left, 10.Px(), Center);
            Assert.Equal("left 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndCenter()
        {
            BackgroundPositionValue converted = (Top, 10.Px(), Center);
            Assert.Equal("top 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndHorizontal()
        {
            BackgroundPositionValue converted = (Center, 10.Px(), Left);
            Assert.Equal("center 10px left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndVertical()
        {
            BackgroundPositionValue converted = (Center, 10.Px(), Top);
            Assert.Equal("center 10px top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndCenter()
        {
            BackgroundPositionValue converted = (Center, 10.Px(), Center);
            Assert.Equal("center 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Left, Top, 10.Px());
            Assert.Equal("left top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Top, Left, 10.Px());
            Assert.Equal("top left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Left, Center, 10.Px());
            Assert.Equal("left center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Top, Center, 10.Px());
            Assert.Equal("top center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Center, Left, 10.Px());
            Assert.Equal("center left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Center, Top, 10.Px());
            Assert.Equal("center top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Center, Center, 10.Px());
            Assert.Equal("center center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Left, 10.Percent(), Top, 10.Px());
            Assert.Equal("left 10% top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Top, 10.Percent(), Left, 10.Px());
            Assert.Equal("top 10% left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Center, 10.Percent(), Left, 10.Px());
            Assert.Equal("center 10% left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Center, 10.Percent(), Top, 10.Px());
            Assert.Equal("center 10% top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthandCenterWithLength()
        {
            BackgroundPositionValue converted = (Left, 10.Percent(), Center, 10.Px());
            Assert.Equal("left 10% center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthCenterWithLength()
        {
            BackgroundPositionValue converted = (Top, 10.Percent(), Center, 10.Px());
            Assert.Equal("top 10% center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Center, 10.Percent(), Center, 10.Px());
            Assert.Equal("center 10% center 10px", converted.ToString());
        }
    }
}
