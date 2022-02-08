using CsCss.Values.Numeric.Angle;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Angle
{
    public class AngleExtensionsTests
    {
        [Fact]
        public void CanConvertDegFromDouble()
        {
            var converted = 2.5.Deg();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertDegFromInt()
        {
            var converted = 2.Deg();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertRadFromDouble()
        {
            var converted = 2.5.Rad();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertRadFromInt()
        {
            var converted = 2.Rad();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertGradFromDouble()
        {
            var converted = 2.5.Grad();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertGradFromInt()
        {
            var converted = 2.Grad();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertTurnFromDouble()
        {
            var converted = 2.5.Turn();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }

        [Fact]
        public void CanConvertTurnFromInt()
        {
            var converted = 2.Turn();
            Assert.Equal(typeof(AngleValue), converted.GetType());
        }
    }
}
