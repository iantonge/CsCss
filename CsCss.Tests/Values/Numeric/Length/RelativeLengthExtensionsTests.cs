using CsCss.Values.Numeric.Length;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Length
{
    public class relativeLengthExtensionsTests
    {
        [Fact]
        public void CanConvertEmFromDouble()
        {
            var converted = 2.5.Em();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5em", converted.ToString());
        }

        [Fact]
        public void CanConvertEmFromInt()
        {
            var converted = 2.Em();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2em", converted.ToString());
        }

        [Fact]
        public void CanConvertExFromDouble()
        {
            var converted = 2.5.Ex();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5ex", converted.ToString());
        }

        [Fact]
        public void CanConvertExFromInt()
        {
            var converted = 2.Ex();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2ex", converted.ToString());
        }

        [Fact]
        public void CanConvertChFromDouble()
        {
            var converted = 2.5.Ch();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5ch", converted.ToString());
        }

        [Fact]
        public void CanConvertChFromInt()
        {
            var converted = 2.Ch();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2ch", converted.ToString());
        }

        [Fact]
        public void CanConvertRemFromDouble()
        {
            var converted = 2.5.Rem();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5rem", converted.ToString());
        }

        [Fact]
        public void CanConvertRemFromInt()
        {
            var converted = 2.Rem();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2rem", converted.ToString());
        }

        [Fact]
        public void CanConvertLhFromDouble()
        {
            var converted = 2.5.Lh();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5lh", converted.ToString());
        }

        [Fact]
        public void CanConvertLhFromInt()
        {
            var converted = 2.Lh();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2lh", converted.ToString());
        }

        [Fact]
        public void CanConvertVwFromDouble()
        {
            var converted = 2.5.Vw();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5vw", converted.ToString());
        }

        [Fact]
        public void CanConvertVwFromInt()
        {
            var converted = 2.Vw();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2vw", converted.ToString());
        }

        [Fact]
        public void CanConvertVhFromDouble()
        {
            var converted = 2.5.Vh();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5vh", converted.ToString());
        }

        [Fact]
        public void CanConvertVhFromInt()
        {
            var converted = 2.Vh();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2vh", converted.ToString());
        }

        [Fact]
        public void CanConvertVMinFromDouble()
        {
            var converted = 2.5.VMin();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5vmin", converted.ToString());
        }

        [Fact]
        public void CanConvertVMinFromInt()
        {
            var converted = 2.VMin();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2vmin", converted.ToString());
        }

        [Fact]
        public void CanConvertVMaxFromDouble()
        {
            var converted = 2.5.VMax();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2.5vmax", converted.ToString());
        }

        [Fact]
        public void CanConvertVMaxFromInt()
        {
            var converted = 2.VMax();
            Assert.Equal(typeof(LengthValue), converted.GetType());
            Assert.Equal("2vmax", converted.ToString());
        }
    }
}
