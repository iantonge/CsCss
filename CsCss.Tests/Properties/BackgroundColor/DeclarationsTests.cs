using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundColor;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundColor()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundColor] = 0xFFFFFF
        };

        Assert.Equal(".test{background-color:#FFFFFF;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
