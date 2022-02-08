using CsCss.Values.Numeric.Length;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Length
{
    public class AbsoluteLengthExtensionsTests
    {
        [Fact]
        public void CanConvertCmFromDouble()
        {
            var converted = 2.5.Cm();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5cm", converted.ToString());
        }

        [Fact]
        public void CanConvertCmFromInt()
        {
            var converted = 2.Cm();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2cm", converted.ToString());
        }

        [Fact]
        public void CanConvertMmFromDouble()
        {
            var converted = 2.5.Mm();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5mm", converted.ToString());
        }

        [Fact]
        public void CanConvertMmFromInt()
        {
            var converted = 2.Mm();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2mm", converted.ToString());
        }

        [Fact]
        public void CanConvertQFromDouble()
        {
            var converted = 2.5.Q();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5Q", converted.ToString());
        }

        [Fact]
        public void CanConvertQFromInt()
        {
            var converted = 2.Q();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2Q", converted.ToString());
        }

        [Fact]
        public void CanConvertInFromDouble()
        {
            var converted = 2.5.In();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5in", converted.ToString());
        }

        [Fact]
        public void CanConvertInFromInt()
        {
            var converted = 2.In();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2in", converted.ToString());
        }

        [Fact]
        public void CanConvertPcFromDouble()
        {
            var converted = 2.5.Pc();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5pc", converted.ToString());
        }

        [Fact]
        public void CanConvertPcFromInt()
        {
            var converted = 2.Pc();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2pc", converted.ToString());
        }

        [Fact]
        public void CanConvertPtFromDouble()
        {
            var converted = 2.5.Pt();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5pt", converted.ToString());
        }

        [Fact]
        public void CanConvertPtFromInt()
        {
            var converted = 2.Pt();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2pt", converted.ToString());
        }

        [Fact]
        public void CanConvertPxFromDouble()
        {
            var converted = 2.5.Px();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5px", converted.ToString());
        }

        [Fact]
        public void CanConvertPxFromInt()
        {
            var converted = 2.Px();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2px", converted.ToString());
        }
    }
}
