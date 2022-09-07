using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.AlignContent
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetAlignContent()
        {
            var declarations = new Declarations()
            {
                [Keywords.AlignContent] = Normal
            };

            Assert.Equal("align-content: normal", declarations.ToStrings().Single());
        }
    }
}
