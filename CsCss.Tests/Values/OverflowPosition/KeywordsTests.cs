using CsCss.Values.OverflowPosition;
using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.OverfowPosition
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersSafeKeyword()
        {
            Assert.Equal("safe", Safe.ToString());
            Assert.Equal(typeof(OverflowPositionKeyword), Safe.GetType());
        }

        [Fact]
        public void RendersUnsafeKeyword()
        {
            Assert.Equal("unsafe", Unsafe.ToString());
            Assert.Equal(typeof(OverflowPositionKeyword), Unsafe.GetType());
        }
    }
}
