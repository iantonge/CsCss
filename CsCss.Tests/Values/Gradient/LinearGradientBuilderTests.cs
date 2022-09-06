using CsCss.Values.Gradient;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class LinearGradientBuilderTests
    {
        [Fact]
        public void CanBuildLinearGradientWithColorStopLengths()
        {
            var gradient = Functions.BuildLinearGradient()
                .WithColorStop(Keywords.Red)
                .WithColorStop(Keywords.Green, 15.Px())
                .WithColorStop(Keywords.Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("linear-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildLinearGradientWithDirection()
        {
            var gradient = Functions.BuildLinearGradient()
                .WithDirection(Keywords.ToRightTop)
                .WithColorStop(Keywords.Red)
                .WithColorStop(Keywords.Green)
                .WithColorStop(Keywords.Blue)
                .Build();

            Assert.Equal("linear-gradient(to right top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildLinearGradientTransitionHints()
        {
            var gradient = Functions.BuildLinearGradient()
                .WithDirection(Keywords.ToRightTop)
                .WithColorStop(Keywords.Red)
                .WithTransitionHint(20.Percent())
                .WithColorStop(Keywords.Green)
                .WithColorStop(Keywords.Blue)
                .WithTransitionHint(80.Percent())
                .WithColorStop(Keywords.Yellow)
                .Build();

            Assert.Equal("linear-gradient(to right top,red,20%,green,blue,80%,yellow)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientWithColorStopLengths()
        {
            var gradient = Functions.BuildRepeatingLinearGradient()
                .WithColorStop(Keywords.Red)
                .WithColorStop(Keywords.Green, 15.Px())
                .WithColorStop(Keywords.Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("repeating-linear-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientWithDirection()
        {
            var gradient = Functions.BuildRepeatingLinearGradient()
                .WithDirection(Keywords.ToRightTop)
                .WithColorStop(Keywords.Red)
                .WithColorStop(Keywords.Green)
                .WithColorStop(Keywords.Blue)
                .Build();

            Assert.Equal("repeating-linear-gradient(to right top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientTransitionHints()
        {
            var gradient = Functions.BuildRepeatingLinearGradient()
                .WithDirection(Keywords.ToRightTop)
                .WithColorStop(Keywords.Red)
                .WithTransitionHint(20.Percent())
                .WithColorStop(Keywords.Green)
                .WithColorStop(Keywords.Blue)
                .WithTransitionHint(80.Percent())
                .WithColorStop(Keywords.Yellow)
                .Build();

            Assert.Equal("repeating-linear-gradient(to right top,red,20%,green,blue,80%,yellow)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }
    }
}
