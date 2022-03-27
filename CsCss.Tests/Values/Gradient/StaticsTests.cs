using CsCss.Values.Gradient;
using CsCss.Values.Gradient.Linear;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class StaticsTests
    {
        [Fact]
        public void RendersGradientDirections()
        {
            Assert.Equal("to left top", Statics.ToLeftTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToLeftTop.GetType());

            Assert.Equal("to top", Statics.ToTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToTop.GetType());

            Assert.Equal("to right top", Statics.ToRightTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToRightTop.GetType());

            Assert.Equal("to right", Statics.ToRight.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToRight.GetType());

            Assert.Equal("to right bottom", Statics.ToRightBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToRightBottom.GetType());

            Assert.Equal("to bottom", Statics.ToBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToBottom.GetType());

            Assert.Equal("to left bottom", Statics.ToLeftBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToLeftBottom.GetType());

            Assert.Equal("to left", Statics.ToLeft.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Statics.ToLeft.GetType());
        }
    }
}
