using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.Color;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundColor()
    {
        var declarations = new Declarations()
        {
            [Keywords.Color] = 0xFFFFFF
        };

        Assert.Equal(".test{color:#FFFFFF;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
