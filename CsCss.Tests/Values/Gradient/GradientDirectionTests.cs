using CsCss.Values.Gradient;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class GradientDirectionTests
    {
        [Fact]
        public void CanConvertFromAngle()
        {
            GradientDirection gradientDirection = 10.Deg();
            Assert.Equal("10deg", gradientDirection.ToString());
        }
    }
}
