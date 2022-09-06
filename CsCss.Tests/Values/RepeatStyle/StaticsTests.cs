using CsCss.Values.RepeatStyle;
using Xunit;

namespace CsCss.Tests.Values.RepeatStyle
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersRepeatXKeyword()
        {
            Assert.Equal("repeat-x", RepeatX.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), RepeatX.GetType());
        }

        [Fact]
        public void RendersRepeatYKeyword()
        {
            Assert.Equal("repeat-y", RepeatY.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), RepeatY.GetType());
        }

        [Fact]
        public void RendersRepeatKeyword()
        {
            Assert.Equal("repeat", Repeat.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Repeat.GetType());
        }

        [Fact]
        public void RendersSpaceKeyword()
        {
            Assert.Equal("space", Space.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Space.GetType());
        }

        [Fact]
        public void RendersRoundKeyword()
        {
            Assert.Equal("round", Round.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Round.GetType());
        }

        [Fact]
        public void RendersNoRepeatKeyword()
        {
            Assert.Equal("no-repeat", NoRepeat.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), NoRepeat.GetType());
        }
    }
}
