using System.Collections.Generic;
using Xunit;
using static CsCss.Keywords;

namespace CsCss.Tests
{
    public class DeclarationsTests
    {
        [Fact]
        public void RendersDeclarations()
        {
            var declarations = new Declarations()
            {
                [Height] = 10.Px(),
                [Color] = Red
            };

            var expected = new List<string>()
            {
                "height: 10px",
                "color: red"
            };

            Assert.Equal(expected, declarations.ToStrings());
        }
    }
}
