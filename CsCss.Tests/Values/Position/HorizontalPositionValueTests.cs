using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class HorizontalPositionValueTests
    {
        [Fact]
        public void CanConvertFromCenterPosition()
        {
            HorizontalPositionValue converted = Statics.Center;
            Assert.Equal("center", converted.ToString());
        }
    }
}
