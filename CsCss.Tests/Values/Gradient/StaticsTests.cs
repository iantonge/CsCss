using CsCss.Values.Gradient;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class StaticsTests
    {
        [Fact]
        public void RendersGradientDirections()
        {
            Assert.Equal("to left top", Statics.ToLeftTop.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToLeftTop.GetType());

            Assert.Equal("to top", Statics.ToTop.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToTop.GetType());

            Assert.Equal("to right top", Statics.ToRightTop.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToRightTop.GetType());

            Assert.Equal("to right", Statics.ToRight.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToRight.GetType());

            Assert.Equal("to right bottom", Statics.ToRightBottom.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToRightBottom.GetType());

            Assert.Equal("to bottom", Statics.ToBottom.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToBottom.GetType());

            Assert.Equal("to left bottom", Statics.ToLeftBottom.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToLeftBottom.GetType());

            Assert.Equal("to left", Statics.ToLeft.ToString());
            Assert.Equal(typeof(GradientDirection), Statics.ToLeft.GetType());
        }
    }
}
