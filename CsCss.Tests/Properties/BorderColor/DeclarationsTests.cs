using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BorderColor
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBorderColor()
        {
            var declarations = new Declarations()
            {
                [Keywords.BorderColor] = Red
            };

            Assert.Equal("border-color: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderTop()
        {
            var declarations = new Declarations()
            {
                [BorderTopColor] = Red
            };

            Assert.Equal("border-top-color: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderBottom()
        {
            var declarations = new Declarations()
            {
                [BorderBottomColor] = Red
            };

            Assert.Equal("border-bottom-color: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderLeft()
        {
            var declarations = new Declarations()
            {
                [BorderLeftColor] = Red
            };

            Assert.Equal("border-left-color: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderRight()
        {
            var declarations = new Declarations()
            {
                [BorderRightColor] = Red
            };

            Assert.Equal("border-right-color: red", declarations.ToStrings().Single());
        }
    }
}
