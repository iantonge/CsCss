using CsCss.Values.Position;
using Xunit;

namespace CsCss.Tests.Values.Position
{
    public class PositionValueTests
    {
        [Fact]
        public void CanConvertFromHorizontalAndVertical()
        {
            PositionValue converted = (Statics.Left, Statics.Top);
            Assert.Equal("left top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVertical()
        {
            PositionValue converted = (Statics.Left, 10.Px(), Statics.Top);
            Assert.Equal("left 10px top", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalAndVerticalWithLength()
        {
            PositionValue converted = (Statics.Left, Statics.Top, 10.Percent());
            Assert.Equal("left top 10%", converted.ToString());
        }

        [Fact]
        public void CanConvertFromHorizontalWithLengthAndVerticalWithLength()
        {
            PositionValue converted = (Statics.Left, 10.Percent(), Statics.Top, 10.Px());
            Assert.Equal("left 10% top 10px", converted.ToString());
        }
    }
}
