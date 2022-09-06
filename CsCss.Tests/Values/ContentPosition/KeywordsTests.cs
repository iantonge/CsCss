using CsCss.Values.ContentPosition;
using Xunit;

namespace CsCss.Tests.Values.ContentPosition
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersStartKeyword()
        {
            Assert.Equal("start", Start.ToString());
            Assert.Equal(typeof(ContentPositionKeyword), Start.GetType());
        }

        [Fact]
        public void RendersEndKeyword()
        {
            Assert.Equal("end", End.ToString());
            Assert.Equal(typeof(ContentPositionKeyword), End.GetType());
        }

        [Fact]
        public void RendersFlexStartKeyword()
        {
            Assert.Equal("flex-start", FlexStart.ToString());
            Assert.Equal(typeof(ContentPositionKeyword), FlexStart.GetType());
        }

        [Fact]
        public void RendersFlexEndKeyword()
        {
            Assert.Equal("flex-end", FlexEnd.ToString());
            Assert.Equal(typeof(ContentPositionKeyword), FlexEnd.GetType());
        }
    }
}
