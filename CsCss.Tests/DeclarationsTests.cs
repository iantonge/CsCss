using System.Collections.Generic;
using Xunit;

namespace CsCss.Tests;

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

        List<string> expected = new()
        {
            "height: 10px",
            "color: red"
        };

        Assert.Equal(expected, declarations.ToStrings());
    }
}
