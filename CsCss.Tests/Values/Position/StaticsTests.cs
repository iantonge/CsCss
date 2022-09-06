using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class KeywordsTests
    {
        [Fact]
        public void CanRenderPositions()
        {
            CenterPositionValue center = Keywords.Center;
            Assert.Equal("center", center.ToString());

            HorizontalPositionValue left = Keywords.Left;
            Assert.Equal("left", left.ToString());

            HorizontalPositionValue right = Keywords.Right;
            Assert.Equal("right", right.ToString());

            VerticalPositionValue top = Keywords.Top;
            Assert.Equal("top", top.ToString());

            VerticalPositionValue bottom = Keywords.Bottom;
            Assert.Equal("bottom", bottom.ToString());
        }
    }
}
