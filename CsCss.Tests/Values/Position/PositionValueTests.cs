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
            PositionValue lengthPercentage = (Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Left, 10.Px());
            Assert.Equal("left 10px", length.ToString());

            PositionValue percentage = (Left, 10.Percent());
            Assert.Equal("left 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalWithOffset()
        {
            PositionValue lengthPercentage = (Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Top, 10.Px());
            Assert.Equal("top 10px", length.ToString());

            PositionValue percentage = (Top, 10.Percent());
            Assert.Equal("top 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertCenterWithOffset()
        {
            PositionValue lengthPercentage = (Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Center, 10.Px());
            Assert.Equal("center 10px", length.ToString());

            PositionValue percentage = (Center, 10.Percent());
            Assert.Equal("center 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndVertical()
        {
            PositionValue position = (Left, Top);
            Assert.Equal("left top", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndCenter()
        {
            PositionValue position = (Left, Center);
            Assert.Equal("left center", position.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndHorizontal()
        {
            PositionValue position = (Top, Left);
            Assert.Equal("top left", position.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndCenter()
        {
            PositionValue position = (Top, Center);
            Assert.Equal("top center", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndHorizontal()
        {
            PositionValue position = (Center, Left);
            Assert.Equal("center left", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndVertical()
        {
            PositionValue position = (Center, Top);
            Assert.Equal("center top", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndCenter()
        {
            PositionValue position = (Center, Center);
            Assert.Equal("center center", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndVerticalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Left, Functions.Calc(10.Percent() - 10.Px()), Top, 10.Px());
            Assert.Equal("left calc(10% - 10px) top 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Left, Functions.Calc(10.Percent() - 10.Px()), Top, 10.Percent());
            Assert.Equal("left calc(10% - 10px) top 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Left, Functions.Calc(10.Percent() - 10.Px()), Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px) top calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Left, 10.Px(), Top, 10.Px());
            Assert.Equal("left 10px top 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Left, 10.Px(), Top, 10.Percent());
            Assert.Equal("left 10px top 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Left, 10.Px(), Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10px top calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Left, 10.Percent(), Top, 10.Px());
            Assert.Equal("left 10% top 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Left, 10.Percent(), Top, 10.Percent());
            Assert.Equal("left 10% top 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Left, 10.Percent(), Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10% top calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Left, Functions.Calc(10.Percent() - 10.Px()), Center, 10.Px());
            Assert.Equal("left calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Left, Functions.Calc(10.Percent() - 10.Px()), Center, 10.Percent());
            Assert.Equal("left calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Left, Functions.Calc(10.Percent() - 10.Px()), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Left, 10.Px(), Center, 10.Px());
            Assert.Equal("left 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Left, 10.Px(), Center, 10.Percent());
            Assert.Equal("left 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Left, 10.Px(), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Left, 10.Percent(), Center, 10.Px());
            Assert.Equal("left 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Left, 10.Percent(), Center, 10.Percent());
            Assert.Equal("left 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Left, 10.Percent(), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndHorizontalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Top, Functions.Calc(10.Percent() - 10.Px()), Left, 10.Px());
            Assert.Equal("top calc(10% - 10px) left 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Top, Functions.Calc(10.Percent() - 10.Px()), Left, 10.Percent());
            Assert.Equal("top calc(10% - 10px) left 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Top, Functions.Calc(10.Percent() - 10.Px()), Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px) left calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Top, 10.Px(), Left, 10.Px());
            Assert.Equal("top 10px left 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Top, 10.Px(), Left, 10.Percent());
            Assert.Equal("top 10px left 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Top, 10.Px(), Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10px left calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Top, 10.Percent(), Left, 10.Px());
            Assert.Equal("top 10% left 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Top, 10.Percent(), Left, 10.Percent());
            Assert.Equal("top 10% left 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Top, 10.Percent(), Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10% left calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Top, Functions.Calc(10.Percent() - 10.Px()), Center, 10.Px());
            Assert.Equal("top calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Top, Functions.Calc(10.Percent() - 10.Px()), Center, 10.Percent());
            Assert.Equal("top calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Top, Functions.Calc(10.Percent() - 10.Px()), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Top, 10.Px(), Center, 10.Px());
            Assert.Equal("top 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Top, 10.Px(), Center, 10.Percent());
            Assert.Equal("top 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Top, 10.Px(), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Top, 10.Percent(), Center, 10.Px());
            Assert.Equal("top 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Top, 10.Percent(), Center, 10.Percent());
            Assert.Equal("top 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Top, 10.Percent(), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndHorizontalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Center, Functions.Calc(10.Percent() - 10.Px()), Left, 10.Px());
            Assert.Equal("center calc(10% - 10px) left 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Center, Functions.Calc(10.Percent() - 10.Px()), Left, 10.Percent());
            Assert.Equal("center calc(10% - 10px) left 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Center, Functions.Calc(10.Percent() - 10.Px()), Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) left calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Center, 10.Px(), Left, 10.Px());
            Assert.Equal("center 10px left 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Center, 10.Px(), Left, 10.Percent());
            Assert.Equal("center 10px left 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Center, 10.Px(), Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px left calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Center, 10.Percent(), Left, 10.Px());
            Assert.Equal("center 10% left 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Center, 10.Percent(), Left, 10.Percent());
            Assert.Equal("center 10% left 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Center, 10.Percent(), Left, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% left calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndVerticalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Center, Functions.Calc(10.Percent() - 10.Px()), Top, 10.Px());
            Assert.Equal("center calc(10% - 10px) top 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Center, Functions.Calc(10.Percent() - 10.Px()), Top, 10.Percent());
            Assert.Equal("center calc(10% - 10px) top 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Center, Functions.Calc(10.Percent() - 10.Px()), Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) top calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Center, 10.Px(), Top, 10.Px());
            Assert.Equal("center 10px top 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Center, 10.Px(), Top, 10.Percent());
            Assert.Equal("center 10px top 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Center, 10.Px(), Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px top calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Center, 10.Percent(), Top, 10.Px());
            Assert.Equal("center 10% top 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Center, 10.Percent(), Top, 10.Percent());
            Assert.Equal("center 10% top 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Center, 10.Percent(), Top, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% top calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Center, Functions.Calc(10.Percent() - 10.Px()), Center, 10.Px());
            Assert.Equal("center calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Center, Functions.Calc(10.Percent() - 10.Px()), Center, 10.Percent());
            Assert.Equal("center calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Center, Functions.Calc(10.Percent() - 10.Px()), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Center, 10.Px(), Center, 10.Px());
            Assert.Equal("center 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Center, 10.Px(), Center, 10.Percent());
            Assert.Equal("center 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Center, 10.Px(), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Center, 10.Percent(), Center, 10.Px());
            Assert.Equal("center 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Center, 10.Percent(), Center, 10.Percent());
            Assert.Equal("center 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Center, 10.Percent(), Center, Functions.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }
    }
}
