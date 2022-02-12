using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class StaticsTests
    {
        [Fact]
        public void CanRenderPositions()
        {
            CenterPositionValue center = Statics.Center;
            Assert.Equal("center", center.ToString());

            HorizontalPositionValue left = Statics.Left;
            Assert.Equal("left", left.ToString());

            HorizontalPositionValue right = Statics.Right;
            Assert.Equal("right", right.ToString());

            VerticalPositionValue top = Statics.Top;
            Assert.Equal("top", top.ToString());

            VerticalPositionValue bottom = Statics.Bottom;
            Assert.Equal("bottom", bottom.ToString());
        }
    }
}
