using CsCss.Properties.BackgroundPosition;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundPosition
{
    public class BackgroundPositionValueTests
    {
        [Fact]
        public void CanConvertFromGlobalKeyword()
        {
            BackgroundPositionValue converted = Keywords.Initial;
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
            BackgroundPositionValue converted = Keywords.Left;
            Assert.Equal("left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndVertical()
        {
            BackgroundPositionValue converted = (Keywords.Left, Keywords.Top);
            Assert.Equal("left top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndHorizontal()
        {
            BackgroundPositionValue converted = (Keywords.Top, Keywords.Left);
            Assert.Equal("top left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndVertical()
        {
            BackgroundPositionValue converted = (Keywords.Center, Keywords.Top);
            Assert.Equal("center top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndHorizontal()
        {
            BackgroundPositionValue converted = (Keywords.Center, Keywords.Left);
            Assert.Equal("center left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndCenter()
        {
            BackgroundPositionValue converted = (Keywords.Left, Keywords.Center);
            Assert.Equal("left center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndCenter()
        {
            BackgroundPositionValue converted = (Keywords.Top, Keywords.Center);
            Assert.Equal("top center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndCenter()
        {
            BackgroundPositionValue converted = (Keywords.Center, Keywords.Center);
            Assert.Equal("center center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVertical()
        {
            BackgroundPositionValue converted = (Keywords.Left, 10.Px(), Keywords.Top);
            Assert.Equal("left 10px top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndHorizontal()
        {
            BackgroundPositionValue converted = (Keywords.Top, 10.Px(), Keywords.Left);
            Assert.Equal("top 10px left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndCenter()
        {
            BackgroundPositionValue converted = (Keywords.Left, 10.Px(), Keywords.Center);
            Assert.Equal("left 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndCenter()
        {
            BackgroundPositionValue converted = (Keywords.Top, 10.Px(), Keywords.Center);
            Assert.Equal("top 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndHorizontal()
        {
            BackgroundPositionValue converted = (Keywords.Center, 10.Px(), Keywords.Left);
            Assert.Equal("center 10px left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndVertical()
        {
            BackgroundPositionValue converted = (Keywords.Center, 10.Px(), Keywords.Top);
            Assert.Equal("center 10px top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndCenter()
        {
            BackgroundPositionValue converted = (Keywords.Center, 10.Px(), Keywords.Center);
            Assert.Equal("center 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Left, Keywords.Top, 10.Px());
            Assert.Equal("left top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Top, Keywords.Left, 10.Px());
            Assert.Equal("top left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Left, Keywords.Center, 10.Px());
            Assert.Equal("left center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Top, Keywords.Center, 10.Px());
            Assert.Equal("top center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Center, Keywords.Left, 10.Px());
            Assert.Equal("center left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Center, Keywords.Top, 10.Px());
            Assert.Equal("center top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Center, Keywords.Center, 10.Px());
            Assert.Equal("center center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Left, 10.Percent(), Keywords.Top, 10.Px());
            Assert.Equal("left 10% top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Top, 10.Percent(), Keywords.Left, 10.Px());
            Assert.Equal("top 10% left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndHorizontalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Center, 10.Percent(), Keywords.Left, 10.Px());
            Assert.Equal("center 10% left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndVerticalWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Center, 10.Percent(), Keywords.Top, 10.Px());
            Assert.Equal("center 10% top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthandCenterWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Left, 10.Percent(), Keywords.Center, 10.Px());
            Assert.Equal("left 10% center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthCenterWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Top, 10.Percent(), Keywords.Center, 10.Px());
            Assert.Equal("top 10% center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndCenterWithLength()
        {
            BackgroundPositionValue converted = (Keywords.Center, 10.Percent(), Keywords.Center, 10.Px());
            Assert.Equal("center 10% center 10px", converted.ToString());
        }
    }
}
