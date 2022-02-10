using CsCss.Values.Percentage;
using Xunit;

namespace CsCss.Tests.Values.Percentage
{
    public class PercentageExtensionsTests
    {
        [Fact]
        public void CanConvertDegFromDouble()
        {
            var converted = 2.5.Percent();
            Assert.Equal("2.5%", converted.ToString());
            Assert.Equal(typeof(PercentageValue), converted.GetType());
        }

        [Fact]
        public void CanConvertDegFromInt()
        {
            var converted = 2.Percent();
            Assert.Equal("2%", converted.ToString());
            Assert.Equal(typeof(PercentageValue), converted.GetType());
        }
    }
}
