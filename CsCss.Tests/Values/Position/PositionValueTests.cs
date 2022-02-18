using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class PositionValueTests
    {
        [Fact]
        public void CanConvertFromLengthPercentage()
        {
            PositionValue converted = Statics.Calc(10.Percent() - 10.Px());
            Assert.Equal("calc(10% - 10px)", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndVertical()
        {
            PositionValue converted = (Statics.Left, Statics.Top);
            Assert.Equal("left top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndHorizontal()
        {
            PositionValue converted = (Statics.Top, Statics.Left);
            Assert.Equal("top left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndVertical()
        {
            PositionValue converted = (Statics.Center, Statics.Top);
            Assert.Equal("center top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndHorizontal()
        {
            PositionValue converted = (Statics.Center, Statics.Left);
            Assert.Equal("center left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndCenter()
        {
            PositionValue converted = (Statics.Left, Statics.Center);
            Assert.Equal("left center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndCenter()
        {
            PositionValue converted = (Statics.Top, Statics.Center);
            Assert.Equal("top center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndCenter()
        {
            PositionValue converted = (Statics.Center, Statics.Center);
            Assert.Equal("center center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVertical()
        {
            PositionValue converted = (Statics.Left, 10.Px(), Statics.Top);
            Assert.Equal("left 10px top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndHorizontal()
        {
            PositionValue converted = (Statics.Top, 10.Px(), Statics.Left);
            Assert.Equal("top 10px left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndCenter()
        {
            PositionValue converted = (Statics.Left, 10.Px(), Statics.Center);
            Assert.Equal("left 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndCenter()
        {
            PositionValue converted = (Statics.Top, 10.Px(), Statics.Center);
            Assert.Equal("top 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndHorizontal()
        {
            PositionValue converted = (Statics.Center, 10.Px(), Statics.Left);
            Assert.Equal("center 10px left", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndVertical()
        {
            PositionValue converted = (Statics.Center, 10.Px(), Statics.Top);
            Assert.Equal("center 10px top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndCenter()
        {
            PositionValue converted = (Statics.Center, 10.Px(), Statics.Center);
            Assert.Equal("center 10px center", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndVerticalWithLength()
        {
            PositionValue converted = (Statics.Left, Statics.Top, 10.Px());
            Assert.Equal("left top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndHorizontalWithLength()
        {
            PositionValue converted = (Statics.Top, Statics.Left, 10.Px());
            Assert.Equal("top left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndCenterWithLength()
        {
            PositionValue converted = (Statics.Left, Statics.Center, 10.Px());
            Assert.Equal("left center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalAndCenterWithLength()
        {
            PositionValue converted = (Statics.Top, Statics.Center, 10.Px());
            Assert.Equal("top center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndHorizontalWithLength()
        {
            PositionValue converted = (Statics.Center, Statics.Left, 10.Px());
            Assert.Equal("center left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndVerticalWithLength()
        {
            PositionValue converted = (Statics.Center, Statics.Top, 10.Px());
            Assert.Equal("center top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterAndCenterWithLength()
        {
            PositionValue converted = (Statics.Center, Statics.Center, 10.Px());
            Assert.Equal("center center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVerticalWithLength()
        {
            PositionValue converted = (Statics.Left, 10.Percent(), Statics.Top, 10.Px());
            Assert.Equal("left 10% top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthAndHorizontalWithLength()
        {
            PositionValue converted = (Statics.Top, 10.Percent(), Statics.Left, 10.Px());
            Assert.Equal("top 10% left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndHorizontalWithLength()
        {
            PositionValue converted = (Statics.Center, 10.Percent(), Statics.Left, 10.Px());
            Assert.Equal("center 10% left 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndVerticalWithLength()
        {
            PositionValue converted = (Statics.Center, 10.Percent(), Statics.Top, 10.Px());
            Assert.Equal("center 10% top 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthandCenterWithLength()
        {
            PositionValue converted = (Statics.Left, 10.Percent(), Statics.Center, 10.Px());
            Assert.Equal("left 10% center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromVerticalWithLengthCenterWithLength()
        {
            PositionValue converted = (Statics.Top, 10.Percent(), Statics.Center, 10.Px());
            Assert.Equal("top 10% center 10px", converted.ToString());
        }

        [Fact]
        public void CanConvertFromCenterWithLengthAndCenterWithLength()
        {
            PositionValue converted = (Statics.Center, 10.Percent(), Statics.Center, 10.Px());
            Assert.Equal("center 10% center 10px", converted.ToString());
        }
    }
}
