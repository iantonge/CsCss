using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundOrigin
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundOriginFromKeyword()
        {
            var declarations = new Declarations()
            {
                [Keywords.BackgroundOrigin] = Keywords.BorderBox
            };

            Assert.Equal("background-origin: border-box", declarations.ToStrings().Single());
        }
    }
}
