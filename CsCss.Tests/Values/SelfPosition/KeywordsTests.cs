using CsCss.Values.SelfPosition;
using Xunit;

namespace CsCss.Tests.Values.SelfPosition
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersStartKeyword()
        {
            Assert.Equal("self-start", SelfStart.ToString());
            Assert.Equal(typeof(SelfPositionKeyword), SelfStart.GetType());
        }

        [Fact]
        public void RendersEndKeyword()
        {
            Assert.Equal("self-end", SelfEnd.ToString());
            Assert.Equal(typeof(SelfPositionKeyword), SelfEnd.GetType());
        }
    }
}
