using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.Height
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundColor()
        {
            var declarations = new Declarations()
            {
                [Statics.Height] = 10.Px()
            };

            Assert.Equal("height: 10px", declarations.ToStrings().Single());
        }
    }
}
