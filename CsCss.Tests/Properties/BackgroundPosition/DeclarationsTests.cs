using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundPosition
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundColor()
        {
            var declarations = new Declarations()
            {
                [Statics.BackgroundPosition] = 10.Px()
            };

            Assert.Equal("background-position: 10px", declarations.ToStrings().Single());
        }
    }
}
