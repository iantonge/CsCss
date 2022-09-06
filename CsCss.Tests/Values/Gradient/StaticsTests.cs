using CsCss.Values.Gradient;
using CsCss.Values.Gradient.Linear;
using Xunit;

namespace CsCss.Tests.Values.Gradient
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersGradientDirections()
        {
            Assert.Equal("to left top", ToLeftTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToLeftTop.GetType());

            Assert.Equal("to top", ToTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToTop.GetType());

            Assert.Equal("to right top", ToRightTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToRightTop.GetType());

            Assert.Equal("to right", ToRight.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToRight.GetType());

            Assert.Equal("to right bottom", ToRightBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToRightBottom.GetType());

            Assert.Equal("to bottom", ToBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToBottom.GetType());

            Assert.Equal("to left bottom", ToLeftBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToLeftBottom.GetType());

            Assert.Equal("to left", ToLeft.ToString());
            Assert.Equal(typeof(LinearGradientDirection), ToLeft.GetType());
        }
    }
}
