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
                [Keywords.BackgroundSize] = Keywords.Contain
            };

            Assert.Equal("background-size: contain", declarations.ToStrings().Single());
        }
    }
}
