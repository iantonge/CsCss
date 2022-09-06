using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class PositionValueTests
    {
        [Fact]
        public void CanConvertFromLength()
        {
            PositionValue position = 10.Px();
            Assert.Equal("10px", position.ToString());
        }

        [Fact]
        public void CanConvertFromPercentage()
        {
            PositionValue position = 10.Percent();
            Assert.Equal("10%", position.ToString());
        }

        [Fact]
        public void CanConvertFromLengthPercentage()
        {
            PositionValue position = Functions.Calc(10.Percent() - 10.Px());
            Assert.Equal("calc(10% - 10px)", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalWithOffset()
        {
            PositionValue lengthPercentage = (Keywords.Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Keywords.Left, 10.Px());
            Assert.Equal("left 10px", length.ToString());

            PositionValue percentage = (Keywords.Left, 10.Percent());
            Assert.Equal("left 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalWithOffset()
        {
            PositionValue lengthPercentage = (Keywords.Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Keywords.Top, 10.Px());
            Assert.Equal("top 10px", length.ToString());

            PositionValue percentage = (Keywords.Top, 10.Percent());
            Assert.Equal("top 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertCenterWithOffset()
        {
            PositionValue lengthPercentage = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Keywords.Center, 10.Px());
            Assert.Equal("center 10px", length.ToString());

            PositionValue percentage = (Keywords.Center, 10.Percent());
            Assert.Equal("center 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndVertical()
        {
            PositionValue position = (Keywords.Left, Keywords.Top);
            Assert.Equal("left top", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndCenter()
        {
            PositionValue position = (Keywords.Left, Keywords.Center);
            Assert.Equal("left center", position.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndHorizontal()
        {
            PositionValue position = (Keywords.Top, Keywords.Left);
            Assert.Equal("top left", position.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndCenter()
        {
            PositionValue position = (Keywords.Top, Keywords.Center);
            Assert.Equal("top center", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndHorizontal()
        {
            PositionValue position = (Keywords.Center, Keywords.Left);
            Assert.Equal("center left", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndVertical()
        {
            PositionValue position = (Keywords.Center, Keywords.Top);
            Assert.Equal("center top", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndCenter()
        {
            PositionValue position = (Keywords.Center, Keywords.Center);
            Assert.Equal("center center", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndVerticalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Keywords.Left, Functions.Calc(10.Percent() - 10.Px()), Keywords.Top, 10.Px());
            Assert.Equal("left calc(10% - 10px) top 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Keywords.Left, Functions.Calc(10.Percent() - 10.Px()), Keywords.Top, 10.Percent());
            Assert.Equal("left calc(10% - 10px) top 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Keywords.Left, Functions.Calc(10.Percent() - 10.Px()), Keywords.Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px) top calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Keywords.Left, 10.Px(), Keywords.Top, 10.Px());
            Assert.Equal("left 10px top 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Keywords.Left, 10.Px(), Keywords.Top, 10.Percent());
            Assert.Equal("left 10px top 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Keywords.Left, 10.Px(), Keywords.Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10px top calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Keywords.Left, 10.Percent(), Keywords.Top, 10.Px());
            Assert.Equal("left 10% top 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Keywords.Left, 10.Percent(), Keywords.Top, 10.Percent());
            Assert.Equal("left 10% top 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Keywords.Left, 10.Percent(), Keywords.Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10% top calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Keywords.Left, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, 10.Px());
            Assert.Equal("left calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Keywords.Left, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, 10.Percent());
            Assert.Equal("left calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Keywords.Left, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Keywords.Left, 10.Px(), Keywords.Center, 10.Px());
            Assert.Equal("left 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Keywords.Left, 10.Px(), Keywords.Center, 10.Percent());
            Assert.Equal("left 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Keywords.Left, 10.Px(), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Keywords.Left, 10.Percent(), Keywords.Center, 10.Px());
            Assert.Equal("left 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Keywords.Left, 10.Percent(), Keywords.Center, 10.Percent());
            Assert.Equal("left 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Keywords.Left, 10.Percent(), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndHorizontalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Keywords.Top, Functions.Calc(10.Percent() - 10.Px()), Keywords.Left, 10.Px());
            Assert.Equal("top calc(10% - 10px) left 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Keywords.Top, Functions.Calc(10.Percent() - 10.Px()), Keywords.Left, 10.Percent());
            Assert.Equal("top calc(10% - 10px) left 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Keywords.Top, Functions.Calc(10.Percent() - 10.Px()), Keywords.Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px) left calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Keywords.Top, 10.Px(), Keywords.Left, 10.Px());
            Assert.Equal("top 10px left 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Keywords.Top, 10.Px(), Keywords.Left, 10.Percent());
            Assert.Equal("top 10px left 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Keywords.Top, 10.Px(), Keywords.Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10px left calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Keywords.Top, 10.Percent(), Keywords.Left, 10.Px());
            Assert.Equal("top 10% left 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Keywords.Top, 10.Percent(), Keywords.Left, 10.Percent());
            Assert.Equal("top 10% left 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Keywords.Top, 10.Percent(), Keywords.Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10% left calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Keywords.Top, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, 10.Px());
            Assert.Equal("top calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Keywords.Top, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, 10.Percent());
            Assert.Equal("top calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Keywords.Top, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Keywords.Top, 10.Px(), Keywords.Center, 10.Px());
            Assert.Equal("top 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Keywords.Top, 10.Px(), Keywords.Center, 10.Percent());
            Assert.Equal("top 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Keywords.Top, 10.Px(), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Keywords.Top, 10.Percent(), Keywords.Center, 10.Px());
            Assert.Equal("top 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Keywords.Top, 10.Percent(), Keywords.Center, 10.Percent());
            Assert.Equal("top 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Keywords.Top, 10.Percent(), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndHorizontalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Left, 10.Px());
            Assert.Equal("center calc(10% - 10px) left 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Left, 10.Percent());
            Assert.Equal("center calc(10% - 10px) left 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) left calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Keywords.Center, 10.Px(), Keywords.Left, 10.Px());
            Assert.Equal("center 10px left 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Keywords.Center, 10.Px(), Keywords.Left, 10.Percent());
            Assert.Equal("center 10px left 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Keywords.Center, 10.Px(), Keywords.Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px left calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Keywords.Center, 10.Percent(), Keywords.Left, 10.Px());
            Assert.Equal("center 10% left 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Keywords.Center, 10.Percent(), Keywords.Left, 10.Percent());
            Assert.Equal("center 10% left 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Keywords.Center, 10.Percent(), Keywords.Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% left calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndVerticalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Top, 10.Px());
            Assert.Equal("center calc(10% - 10px) top 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Top, 10.Percent());
            Assert.Equal("center calc(10% - 10px) top 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) top calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Keywords.Center, 10.Px(), Keywords.Top, 10.Px());
            Assert.Equal("center 10px top 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Keywords.Center, 10.Px(), Keywords.Top, 10.Percent());
            Assert.Equal("center 10px top 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Keywords.Center, 10.Px(), Keywords.Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px top calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Keywords.Center, 10.Percent(), Keywords.Top, 10.Px());
            Assert.Equal("center 10% top 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Keywords.Center, 10.Percent(), Keywords.Top, 10.Percent());
            Assert.Equal("center 10% top 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Keywords.Center, 10.Percent(), Keywords.Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% top calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, 10.Px());
            Assert.Equal("center calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, 10.Percent());
            Assert.Equal("center calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Keywords.Center, Functions.Calc(10.Percent() - 10.Px()), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Keywords.Center, 10.Px(), Keywords.Center, 10.Px());
            Assert.Equal("center 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Keywords.Center, 10.Px(), Keywords.Center, 10.Percent());
            Assert.Equal("center 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Keywords.Center, 10.Px(), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Keywords.Center, 10.Percent(), Keywords.Center, 10.Px());
            Assert.Equal("center 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Keywords.Center, 10.Percent(), Keywords.Center, 10.Percent());
            Assert.Equal("center 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Keywords.Center, 10.Percent(), Keywords.Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }
    }
}
