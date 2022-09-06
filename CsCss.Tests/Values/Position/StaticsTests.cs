using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class KeywordsTests
    {
        [Fact]
        public void CanRenderPositions()
        {
            CenterPositionValue center = Center;
            Assert.Equal("center", center.ToString());

            HorizontalPositionValue left = Left;
            Assert.Equal("left", left.ToString());

            HorizontalPositionValue right = Right;
            Assert.Equal("right", right.ToString());

            VerticalPositionValue top = Top;
            Assert.Equal("top", top.ToString());

            VerticalPositionValue bottom = Bottom;
            Assert.Equal("bottom", bottom.ToString());
        }
    }
}
