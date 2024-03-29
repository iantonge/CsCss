﻿using CsCss.Values.Gradient;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class LinearGradientBuilderTests
    {
        [Fact]
        public void CanBuildLinearGradientWithColorStopLengths()
        {
            var gradient = Functions.BuildLinearGradient()
                .WithColorStop(Red)
                .WithColorStop(Green, 15.Px())
                .WithColorStop(Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("linear-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildLinearGradientWithDirection()
        {
            var gradient = Functions.BuildLinearGradient()
                .WithDirection(ToRightTop)
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("linear-gradient(to right top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildLinearGradientTransitionHints()
        {
            var gradient = Functions.BuildLinearGradient()
                .WithDirection(ToRightTop)
                .WithColorStop(Red)
                .WithTransitionHint(20.Percent())
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .WithTransitionHint(80.Percent())
                .WithColorStop(Yellow)
                .Build();

            Assert.Equal("linear-gradient(to right top,red,20%,green,blue,80%,yellow)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientWithColorStopLengths()
        {
            var gradient = Functions.BuildRepeatingLinearGradient()
                .WithColorStop(Red)
                .WithColorStop(Green, 15.Px())
                .WithColorStop(Blue, 15.Px(), 20.Percent())
                .Build();

            Assert.Equal("repeating-linear-gradient(red,green 15px,blue 15px 20%)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientWithDirection()
        {
            var gradient = Functions.BuildRepeatingLinearGradient()
                .WithDirection(ToRightTop)
                .WithColorStop(Red)
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .Build();

            Assert.Equal("repeating-linear-gradient(to right top,red,green,blue)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }

        [Fact]
        public void CanBuildRepeatingLinearGradientTransitionHints()
        {
            var gradient = Functions.BuildRepeatingLinearGradient()
                .WithDirection(ToRightTop)
                .WithColorStop(Red)
                .WithTransitionHint(20.Percent())
                .WithColorStop(Green)
                .WithColorStop(Blue)
                .WithTransitionHint(80.Percent())
                .WithColorStop(Yellow)
                .Build();

            Assert.Equal("repeating-linear-gradient(to right top,red,20%,green,blue,80%,yellow)", gradient.ToString());
            Assert.Equal(typeof(GradientValue), gradient.GetType());
        }
    }
}
