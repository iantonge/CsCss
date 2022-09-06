using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundRepeat
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundRepeatFromKeyword()
        {
            var declarations = new Declarations()
            {
                [Keywords.BackgroundRepeat] = Repeat
            };

            Assert.Equal("background-repeat: repeat", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBackgroundRepeatFromTuple()
        {
            var declarations = new Declarations()
            {
                [Keywords.BackgroundRepeat] = (Space, NoRepeat)
            };

            Assert.Equal("background-repeat: space no-repeat", declarations.ToStrings().Single());
        }
    }
}
