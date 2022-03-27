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
                [Statics.BackgroundRepeat] = Statics.Repeat
            };

            Assert.Equal("background-repeat: repeat", declarations.ToStrings().Single());
        }

        [Fact]
        public void CanSetBackgroundRepeatFromTuple()
        {
            var declarations = new Declarations()
            {
                [Statics.BackgroundRepeat] = (Statics.Space, Statics.NoRepeat)
            };

            Assert.Equal("background-repeat: space no-repeat", declarations.ToStrings().Single());
        }
    }
}
