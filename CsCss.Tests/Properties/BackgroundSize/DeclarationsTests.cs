using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundSize
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundSize()
        {
            var declarations = new Declarations()
            {
                [Statics.BackgroundSize] = Statics.Contain
            };

            Assert.Equal("background-size: contain", declarations.ToStrings().Single());
        }
    }
}
