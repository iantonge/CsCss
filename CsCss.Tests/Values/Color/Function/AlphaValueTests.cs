using CsCss.Values.Color.Function;
using Xunit;

namespace CsCss.Tests.Values.Color.Function
{
    public class AlphaValueTests
    {
        [Fact]
        public void CanConvertFromInt()
        {
            AlphaValue alphaValue = 2;
            Assert.Equal("2", alphaValue.ToString());
        }

        [Fact]
        public void CanConvertFromDouble()
        {
            AlphaValue alphaValue = 2.5;
            Assert.Equal("2.5", alphaValue.ToString());
        }


        [Fact]
        public void CanConvertFromPercentageValue()
        {
            var percentage = 2.5.Percent();
            AlphaValue alphaValue = percentage;
            Assert.Equal("2.5%", alphaValue.ToString());
        }
    }
}
