using CsCss.Values.Gradient;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class ConicGradientBuilderTests
    {
        [Fact]
        public void CanBuildConicGradientWithColorStopLengths()
        {
            var gradient = Functions.BuildConicGradient()
                .WithColorStop(Red)
                .WithColorStop(Green, 15.Deg())
                .WithColorStop(Blue, 30.Deg(), 25.Percent())
                .Build();

            Assert.Equal("conic-gradient(red,green 15deg,blue 30deg 25%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildConicGradientFromAngle()
        {
            var gradient = Functions.BuildConicGradient()
                .FromAngle(10.Rad())
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("conic-gradient(from 10rad,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildConicGradientAtPosition()
        {
            var gradient = Functions.BuildConicGradient()
                .AtPosition(Top)
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("conic-gradient(at top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildConicGradientFromAngleAtPosition()
        {
            var gradient = Functions.BuildConicGradient()
                .FromAngle(90.Deg())
                .AtPosition((Top, Left))
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("conic-gradient(from 90deg at top left,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }
    }
}
