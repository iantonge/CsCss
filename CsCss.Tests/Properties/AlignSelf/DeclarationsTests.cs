using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.AlignSelf
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetAlignContent()
        {
            var declarations = new Declarations()
            {
                [Keywords.AlignSelf] = Normal
            };

            Assert.Equal("align-self: normal", declarations.ToStrings().Single());
        }
    }
}
