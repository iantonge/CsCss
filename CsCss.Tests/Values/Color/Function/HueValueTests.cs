using CsCss.Values.Color.Function;
using Xunit;

namespace CsCss.Tests.Values.Color.Function
{
    public sealed class HueValueTests
    {
        [Fact]
        public void CanConvertFromInt()
        {
            HueValue alphaValue = 2;
            Assert.Equal("2", alphaValue.ToString());
        }

        [Fact]
        public void CanConvertFromDouble()
        {
            HueValue hueValue = 2.5;
            Assert.Equal("2.5", hueValue.ToString());
        }


        [Fact]
        public void CanConvertFromAngleValue()
        {
            var angle = 2.5.Deg();
            HueValue hueValue = angle;
            Assert.Equal("2.5deg", hueValue.ToString());
        }
    }
}
