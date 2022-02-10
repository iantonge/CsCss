using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.Color
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundColor()
        {
            var declarations = new Declarations()
            {
                [Statics.Color] = 0xFFFFFF
            };

            Assert.Equal("color: #FFFFFF", declarations.ToStrings().Single());
        }
    }
}
