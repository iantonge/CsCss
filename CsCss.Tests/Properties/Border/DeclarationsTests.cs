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
                [Keywords.Border] = Keywords.Red
            };

            Assert.Equal("border: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderTop()
        {
            var declarations = new Declarations()
            {
                [Keywords.BorderTop] = Keywords.Red
            };

            Assert.Equal("border-top: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderBottom()
        {
            var declarations = new Declarations()
            {
                [Keywords.BorderBottom] = Keywords.Red
            };

            Assert.Equal("border-bottom: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderLeft()
        {
            var declarations = new Declarations()
            {
                [Keywords.BorderLeft] = Keywords.Red
            };

            Assert.Equal("border-left: red", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBorderRight()
        {
            var declarations = new Declarations()
            {
                [Keywords.BorderRight] = Keywords.Red
            };

            Assert.Equal("border-right: red", declarations.ToStrings().Single());
        }
    }
}
