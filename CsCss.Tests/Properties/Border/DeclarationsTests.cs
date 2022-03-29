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
    }
}
