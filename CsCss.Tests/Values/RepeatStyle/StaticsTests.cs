using CsCss.Values.RepeatStyle;
using Xunit;

namespace CsCss.Tests.Values.RepeatStyle
{
    public class StaticsTests
    {
        [Fact]
        public void RendersRepeatXKeyword()
        {
            Assert.Equal("repeat-x", Statics.RepeatX.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Statics.NoRepeat.GetType());
        }

        [Fact]
        public void RendersRepeatYKeyword()
        {
            Assert.Equal("repeat-y", Statics.RepeatY.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Statics.NoRepeat.GetType());
        }

        [Fact]
        public void RendersRepeatKeyword()
        {
            Assert.Equal("repeat", Statics.Repeat.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Statics.NoRepeat.GetType());
        }

        [Fact]
        public void RendersSpaceKeyword()
        {
            Assert.Equal("space", Statics.Space.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Statics.NoRepeat.GetType());
        }

        [Fact]
        public void RendersRoundKeyword()
        {
            Assert.Equal("round", Statics.Round.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Statics.NoRepeat.GetType());
        }

        [Fact]
        public void RendersNoRepeatKeyword()
        {
            Assert.Equal("no-repeat", Statics.NoRepeat.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Statics.NoRepeat.GetType());
        }
    }
}
