using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.Border
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBorder()
        {
            var declarations = new Declarations()
            {
                [Statics.Border] = Statics.Red
            };

            Assert.Equal("border: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderTop()
        {
            var declarations = new Declarations()
            {
                [Statics.BorderTop] = Statics.Red
            };

            Assert.Equal("border-top: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderBottom()
        {
            var declarations = new Declarations()
            {
                [Statics.BorderBottom] = Statics.Red
            };

            Assert.Equal("border-bottom: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderLeft()
        {
            var declarations = new Declarations()
            {
                [Statics.BorderLeft] = Statics.Red
            };

            Assert.Equal("border-left: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderRight()
        {
            var declarations = new Declarations()
            {
                [Statics.BorderRight] = Statics.Red
            };

            Assert.Equal("border-right: red", declarations.ToStrings().Single());
        }
    }
}
