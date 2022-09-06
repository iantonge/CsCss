using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundAttachment
{
    public class DeclarationsTests
    {
        [Fact]
        public void CanSetBackgroundAttachment()
        {
            var declarations = new Declarations()
            {
                [Keywords.BackgroundAttachment] = Keywords.Scroll
            };

            Assert.Equal("background-attachment: scroll", declarations.ToStrings().Single());
        }
    }
}
