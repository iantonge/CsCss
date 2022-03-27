using CsCss.Values.Gradient.Linear;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class LinearGradientDirectionTests
    {
        [Fact]
        public void CanConvertFromAngle()
        {
            LinearGradientDirection gradientDirection = 10.Deg();
            Assert.Equal("10deg", gradientDirection.ToString());
        }
    }
}
