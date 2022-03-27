using CsCss.Values.Gradient;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class ConicGradientBuilderTests
    {
        [Fact]
        public void CanBuildConicGradientWithColorStopLengths()
        {
            var gradient = Statics.BuildConicGradient()
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green, 15.Deg())
                .WithColorStop(Statics.Blue, 30.Deg(), 25.Percent())
                .Build();

            Assert.Equal("conic-gradient(red,green 15deg,blue 30deg 25%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildConicGradientFromAngle()
        {
            var gradient = Statics.BuildConicGradient()
                .FromAngle(10.Rad())
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("conic-gradient(from 10rad,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildConicGradientAtPosition()
        {
            var gradient = Statics.BuildConicGradient()
                .AtPosition(Statics.Top)
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("conic-gradient(at top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildConicGradientFromAngleAtPosition()
        {
            var gradient = Statics.BuildConicGradient()
                .FromAngle(90.Deg())
                .AtPosition((Statics.Top, Statics.Left))
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("conic-gradient(from 90deg at top left,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }
    }
}
