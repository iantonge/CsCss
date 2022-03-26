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
            var gradient = Statics.BuildRadialGradient()
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green, 15.Px())
                .WithColorStop(Statics.Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("radial-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradient()
        {
            var gradient = Statics.BuildRadialGradient()
                .Circular()
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("radial-gradient(circle,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradientAndRadius()
        {
            var gradient = Statics.BuildRadialGradient()
                .Circular(10.Px())
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("radial-gradient(circle 10px,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradientWithSize()
        {
            var gradient = Statics.BuildRadialGradient()
                .Circular(Statics.FarthestCorner)
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("radial-gradient(circle farthest-corner,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildCircularRadialGradientWithSizeAndPosition()
        {
            var gradient = Statics.BuildRadialGradient()
                .Circular(Statics.FarthestCorner)
                .AtPosition((Statics.Top, 10.Percent(), Statics.Right, 10.Px()))
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("radial-gradient(circle farthest-corner at top 10% right 10px,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }
    }
}
