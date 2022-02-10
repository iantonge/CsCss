using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundColor
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundColor()
        {
            var declarations = new Declarations()
            {
                [Statics.BackgroundColor] = 0xFFFFFF
            };

            Assert.Equal("background-color: #FFFFFF", declarations.ToStrings().Single());
        }
    }
}
