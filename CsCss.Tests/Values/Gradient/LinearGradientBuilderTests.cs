using CsCss.Values.Gradient;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class LinearGradientBuilderTests
    {
        [Fact]
        public void CanBuildLinearGradientWithColorStopLengths()
        {
            var gradient = Statics.BuildLinearGradient()
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green, 15.Px())
                .WithColorStop(Statics.Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("linear-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildLinearGradientWithDirection()
        {
            var gradient = Statics.BuildLinearGradient(Statics.ToRightTop)
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("linear-gradient(to right top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildLinearGradientTransitionHints()
        {
            var gradient = Statics.BuildLinearGradient(Statics.ToRightTop)
                .WithColorStop(Statics.Red)
                .WithTransitionHint(20.Percent())
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .WithTransitionHint(80.Percent())
                .WithColorStop(Statics.Yellow)
                .Build();

            Assert.Equal("linear-gradient(to right top,red,20%,green,blue,80%,yellow)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientWithColorStopLengths()
        {
            var gradient = Statics.BuildRepeatingLinearGradient()
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green, 15.Px())
                .WithColorStop(Statics.Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("repeating-linear-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientWithDirection()
        {
            var gradient = Statics.BuildRepeatingLinearGradient(Statics.ToRightTop)
                .WithColorStop(Statics.Red)
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .Build();

            Assert.Equal("repeating-linear-gradient(to right top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientTransitionHints()
        {
            var gradient = Statics.BuildRepeatingLinearGradient(Statics.ToRightTop)
                .WithColorStop(Statics.Red)
                .WithTransitionHint(20.Percent())
                .WithColorStop(Statics.Green)
                .WithColorStop(Statics.Blue)
                .WithTransitionHint(80.Percent())
                .WithColorStop(Statics.Yellow)
                .Build();

            Assert.Equal("repeating-linear-gradient(to right top,red,20%,green,blue,80%,yellow)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }
    }
}
