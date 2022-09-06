using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundImage
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundImageFromKeyword()
        {
            var declarations = new Declarations()
            {
                [Keywords.BackgroundRepeat] = Keywords.Repeat
            };

            Assert.Equal("background-repeat: repeat", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBackgroundRepeatFromTuple()
        {
            var declarations = new Declarations()
            {
                [Keywords.BackgroundRepeat] = (Keywords.Space, Keywords.NoRepeat)
            };

            Assert.Equal("background-repeat: space no-repeat", declarations.ToStrings().Single());
        }
    }
}
