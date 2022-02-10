using CsCss.Values.Time;
using Xunit;

namespace CsCss.Tests.Values.Time
{
    public class TimeExtensionsTests
    {
        [Fact]
        public void CanConvertSFromDouble()
        {
            var converted = 2.5.S();
            Assert.Equal("2.5s", converted.ToString());
            Assert.Equal(typeof(TimeValue), converted.GetType());
        }

        [Fact]
        public void CanConvertSFromInt()
        {
            var converted = 2.S();
            Assert.Equal("2s", converted.ToString());
            Assert.Equal(typeof(TimeValue), converted.GetType());
        }

        [Fact]
        public void CanConvertMsFromDouble()
        {
            var converted = 2.5.Ms();
            Assert.Equal("2.5ms", converted.ToString());
            Assert.Equal(typeof(TimeValue), converted.GetType());
        }

        [Fact]
        public void CanConvertMsFromInt()
        {
            var converted = 2.Ms();
            Assert.Equal("2ms", converted.ToString());
            Assert.Equal(typeof(TimeValue), converted.GetType());
        }
    }
}
