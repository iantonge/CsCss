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

        Assert.Equal(".test{height:10px;color:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
