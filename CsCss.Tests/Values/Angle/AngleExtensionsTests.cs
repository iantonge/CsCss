using CsCss.Values.Angle;
using Xunit;

namespace CsCss.Tests.Values.Angle
{
    public class AngleExtensionsTests
    {
        [Fact]
        public void CanConvertDegFromDouble()
        {
            var converted = 2.5.Deg();
            Assert.Equal("2.5deg", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertDegFromInt()
        {
            var converted = 2.Deg();
            Assert.Equal("2deg", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertRadFromDouble()
        {
            var converted = 2.5.Rad();
            Assert.Equal("2.5rad", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertRadFromInt()
        {
            var converted = 2.Rad();
            Assert.Equal("2rad", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertGradFromDouble()
        {
            var converted = 2.5.Grad();
            Assert.Equal("2.5grad", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertGradFromInt()
        {
            var converted = 2.Grad();
            Assert.Equal("2grad", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertTurnFromDouble()
        {
            var converted = 2.5.Turn();
            Assert.Equal("2.5turn", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertTurnFromInt()
        {
            var converted = 2.Turn();
            Assert.Equal("2turn", converted.ToString());
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }
    }
}
