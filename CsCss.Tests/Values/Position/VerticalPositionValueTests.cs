using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class VerticalPositionValueTests
    {
        [Fact]
        public void CanConvertFromCenterPosition()
        {
            VerticalPositionValue converted = Statics.Center;
            Assert.Equal("center", converted.ToString());
        }
    }
}
