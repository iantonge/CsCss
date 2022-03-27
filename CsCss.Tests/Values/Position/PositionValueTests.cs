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
            PositionValue position = Statics.Calc(10.Percent() - 10.Px());
            Assert.Equal("calc(10% - 10px)", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalWithOffset()
        {
            PositionValue lengthPercentage = (Statics.Left, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Statics.Left, 10.Px());
            Assert.Equal("left 10px", length.ToString());

            PositionValue percentage = (Statics.Left, 10.Percent());
            Assert.Equal("left 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalWithOffset()
        {
            PositionValue lengthPercentage = (Statics.Top, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Statics.Top, 10.Px());
            Assert.Equal("top 10px", length.ToString());

            PositionValue percentage = (Statics.Top, 10.Percent());
            Assert.Equal("top 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertCenterWithOffset()
        {
            PositionValue lengthPercentage = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px)", lengthPercentage.ToString());

            PositionValue length = (Statics.Center, 10.Px());
            Assert.Equal("center 10px", length.ToString());

            PositionValue percentage = (Statics.Center, 10.Percent());
            Assert.Equal("center 10%", percentage.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndVertical()
        {
            PositionValue position = (Statics.Left, Statics.Top);
            Assert.Equal("left top", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndCenter()
        {
            PositionValue position = (Statics.Left, Statics.Center);
            Assert.Equal("left center", position.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndHorizontal()
        {
            PositionValue position = (Statics.Top, Statics.Left);
            Assert.Equal("top left", position.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndCenter()
        {
            PositionValue position = (Statics.Top, Statics.Center);
            Assert.Equal("top center", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndHorizontal()
        {
            PositionValue position = (Statics.Center, Statics.Left);
            Assert.Equal("center left", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndVertical()
        {
            PositionValue position = (Statics.Center, Statics.Top);
            Assert.Equal("center top", position.ToString());
        }

        [Fact]
        public void CanConvertCenterAndCenter()
        {
            PositionValue position = (Statics.Center, Statics.Center);
            Assert.Equal("center center", position.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndVerticalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Statics.Left, Statics.Calc(10.Percent() - 10.Px()), Statics.Top, 10.Px());
            Assert.Equal("left calc(10% - 10px) top 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Statics.Left, Statics.Calc(10.Percent() - 10.Px()), Statics.Top, 10.Percent());
            Assert.Equal("left calc(10% - 10px) top 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Statics.Left, Statics.Calc(10.Percent() - 10.Px()), Statics.Top, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px) top calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Statics.Left, 10.Px(), Statics.Top, 10.Px());
            Assert.Equal("left 10px top 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Statics.Left, 10.Px(), Statics.Top, 10.Percent());
            Assert.Equal("left 10px top 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Statics.Left, 10.Px(), Statics.Top, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10px top calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Statics.Left, 10.Percent(), Statics.Top, 10.Px());
            Assert.Equal("left 10% top 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Statics.Left, 10.Percent(), Statics.Top, 10.Percent());
            Assert.Equal("left 10% top 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Statics.Left, 10.Percent(), Statics.Top, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10% top calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertHorizontalAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Statics.Left, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, 10.Px());
            Assert.Equal("left calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Statics.Left, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, 10.Percent());
            Assert.Equal("left calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Statics.Left, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Statics.Left, 10.Px(), Statics.Center, 10.Px());
            Assert.Equal("left 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Statics.Left, 10.Px(), Statics.Center, 10.Percent());
            Assert.Equal("left 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Statics.Left, 10.Px(), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Statics.Left, 10.Percent(), Statics.Center, 10.Px());
            Assert.Equal("left 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Statics.Left, 10.Percent(), Statics.Center, 10.Percent());
            Assert.Equal("left 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Statics.Left, 10.Percent(), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("left 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndHorizontalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Statics.Top, Statics.Calc(10.Percent() - 10.Px()), Statics.Left, 10.Px());
            Assert.Equal("top calc(10% - 10px) left 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Statics.Top, Statics.Calc(10.Percent() - 10.Px()), Statics.Left, 10.Percent());
            Assert.Equal("top calc(10% - 10px) left 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Statics.Top, Statics.Calc(10.Percent() - 10.Px()), Statics.Left, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px) left calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Statics.Top, 10.Px(), Statics.Left, 10.Px());
            Assert.Equal("top 10px left 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Statics.Top, 10.Px(), Statics.Left, 10.Percent());
            Assert.Equal("top 10px left 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Statics.Top, 10.Px(), Statics.Left, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10px left calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Statics.Top, 10.Percent(), Statics.Left, 10.Px());
            Assert.Equal("top 10% left 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Statics.Top, 10.Percent(), Statics.Left, 10.Percent());
            Assert.Equal("top 10% left 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Statics.Top, 10.Percent(), Statics.Left, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10% left calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertVerticalAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Statics.Top, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, 10.Px());
            Assert.Equal("top calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Statics.Top, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, 10.Percent());
            Assert.Equal("top calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Statics.Top, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Statics.Top, 10.Px(), Statics.Center, 10.Px());
            Assert.Equal("top 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Statics.Top, 10.Px(), Statics.Center, 10.Percent());
            Assert.Equal("top 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Statics.Top, 10.Px(), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Statics.Top, 10.Percent(), Statics.Center, 10.Px());
            Assert.Equal("top 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Statics.Top, 10.Percent(), Statics.Center, 10.Percent());
            Assert.Equal("top 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Statics.Top, 10.Percent(), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("top 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndHorizontalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Left, 10.Px());
            Assert.Equal("center calc(10% - 10px) left 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Left, 10.Percent());
            Assert.Equal("center calc(10% - 10px) left 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Left, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) left calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Statics.Center, 10.Px(), Statics.Left, 10.Px());
            Assert.Equal("center 10px left 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Statics.Center, 10.Px(), Statics.Left, 10.Percent());
            Assert.Equal("center 10px left 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Statics.Center, 10.Px(), Statics.Left, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px left calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Statics.Center, 10.Percent(), Statics.Left, 10.Px());
            Assert.Equal("center 10% left 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Statics.Center, 10.Percent(), Statics.Left, 10.Percent());
            Assert.Equal("center 10% left 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Statics.Center, 10.Percent(), Statics.Left, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% left calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndVerticalWithOffsets()
        {
            PositionValue lengthPercentageLength = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Top, 10.Px());
            Assert.Equal("center calc(10% - 10px) top 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Top, 10.Percent());
            Assert.Equal("center calc(10% - 10px) top 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Top, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) top calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Statics.Center, 10.Px(), Statics.Top, 10.Px());
            Assert.Equal("center 10px top 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Statics.Center, 10.Px(), Statics.Top, 10.Percent());
            Assert.Equal("center 10px top 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Statics.Center, 10.Px(), Statics.Top, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px top calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Statics.Center, 10.Percent(), Statics.Top, 10.Px());
            Assert.Equal("center 10% top 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Statics.Center, 10.Percent(), Statics.Top, 10.Percent());
            Assert.Equal("center 10% top 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Statics.Center, 10.Percent(), Statics.Top, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% top calc(10% - 10px)", percentageLengthPercentage.ToString());
        }

        [Fact]
        public void CanConvertCenterAndCenterWithOffsets()
        {
            PositionValue lengthPercentageLength = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, 10.Px());
            Assert.Equal("center calc(10% - 10px) center 10px", lengthPercentageLength.ToString());

            PositionValue lengthPercentagePercentage = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, 10.Percent());
            Assert.Equal("center calc(10% - 10px) center 10%", lengthPercentagePercentage.ToString());

            PositionValue lengthPercentageLengthPercentage = (Statics.Center, Statics.Calc(10.Percent() - 10.Px()), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center calc(10% - 10px) center calc(10% - 10px)", lengthPercentageLengthPercentage.ToString());

            PositionValue lengthLength = (Statics.Center, 10.Px(), Statics.Center, 10.Px());
            Assert.Equal("center 10px center 10px", lengthLength.ToString());

            PositionValue lengthPercentage = (Statics.Center, 10.Px(), Statics.Center, 10.Percent());
            Assert.Equal("center 10px center 10%", lengthPercentage.ToString());

            PositionValue lengthLengthPercentage = (Statics.Center, 10.Px(), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10px center calc(10% - 10px)", lengthLengthPercentage.ToString());

            PositionValue percentageLength = (Statics.Center, 10.Percent(), Statics.Center, 10.Px());
            Assert.Equal("center 10% center 10px", percentageLength.ToString());

            PositionValue percentagePercentage = (Statics.Center, 10.Percent(), Statics.Center, 10.Percent());
            Assert.Equal("center 10% center 10%", percentagePercentage.ToString());

            PositionValue percentageLengthPercentage = (Statics.Center, 10.Percent(), Statics.Center, Statics.Calc(10.Percent() - 10.Px()));
            Assert.Equal("center 10% center calc(10% - 10px)", percentageLengthPercentage.ToString());
        }
    }
}
