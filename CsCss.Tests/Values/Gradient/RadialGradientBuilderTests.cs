using CsCss.Values.Gradient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class RadialGradientBuilderTests
    {
        [Fact]
        public void CanBuildRadialGradientWithColorStopLengths()
        {
            var gradient = Functions.BuildRadialGradient()
                .WithColorStop(Red)
                .WithColorStop(Green, 15.Px())
                .WithColorStop(Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("radial-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradient()
        {
            var gradient = Functions.BuildRadialGradient()
                .Circular()
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("radial-gradient(circle,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradientAndRadius()
        {
            var gradient = Functions.BuildRadialGradient()
                .Circular(10.Px())
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("radial-gradient(circle 10px,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradientWithSize()
        {
            var gradient = Functions.BuildRadialGradient()
                .Circular(FarthestCorner)
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("radial-gradient(circle farthest-corner,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradientWithSizeAndPosition()
        {
            var gradient = Functions.BuildRadialGradient()
                .Circular(FarthestCorner)
                .AtPosition((Top, 10.Percent(), Right, 10.Px()))
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("radial-gradient(circle farthest-corner at top 10% right 10px,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }
    }
}
