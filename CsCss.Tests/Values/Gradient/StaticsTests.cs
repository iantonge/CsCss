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
            Assert.Equal("to left top", Keywords.ToLeftTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToLeftTop.GetType());

            Assert.Equal("to top", Keywords.ToTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToTop.GetType());

            Assert.Equal("to right top", Keywords.ToRightTop.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToRightTop.GetType());

            Assert.Equal("to right", Keywords.ToRight.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToRight.GetType());

            Assert.Equal("to right bottom", Keywords.ToRightBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToRightBottom.GetType());

            Assert.Equal("to bottom", Keywords.ToBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToBottom.GetType());

            Assert.Equal("to left bottom", Keywords.ToLeftBottom.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToLeftBottom.GetType());

            Assert.Equal("to left", Keywords.ToLeft.ToString());
            Assert.Equal(typeof(LinearGradientDirection), Keywords.ToLeft.GetType());
        }
    }
}
