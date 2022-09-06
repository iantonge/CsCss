using CsCss.Values.RepeatStyle;
using Xunit;

namespace CsCss.Tests.Values.RepeatStyle
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersRepeatXKeyword()
        {
            Assert.Equal("repeat-x", Keywords.RepeatX.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Keywords.RepeatX.GetType());
        }

        [Fact]
        public void RendersRepeatYKeyword()
        {
            Assert.Equal("repeat-y", Keywords.RepeatY.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Keywords.RepeatY.GetType());
        }

        [Fact]
        public void RendersRepeatKeyword()
        {
            Assert.Equal("repeat", Keywords.Repeat.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Keywords.Repeat.GetType());
        }

        [Fact]
        public void RendersSpaceKeyword()
        {
            Assert.Equal("space", Keywords.Space.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Keywords.Space.GetType());
        }

        [Fact]
        public void RendersRoundKeyword()
        {
            Assert.Equal("round", Keywords.Round.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Keywords.Round.GetType());
        }

        [Fact]
        public void RendersNoRepeatKeyword()
        {
            Assert.Equal("no-repeat", Keywords.NoRepeat.ToString());
            Assert.Equal(typeof(RepeatStyleKeyword), Keywords.NoRepeat.GetType());
        }
    }
}
