using CsCss.Values.Numeric.Percentage;
using Xunit;

namespace CsCss.Tests.Values.Numeric.Percentage
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
