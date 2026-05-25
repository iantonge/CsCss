using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.AccentColor;

public class DeclarationsTests
{
    [Fact]
    public void CanSetAccentColor()
    {
        var declarations = new Declarations()
        {
            [Keywords.AccentColor] = Rgb(150, 50.Percent(), 255)
        };

        Assert.Equal(".test{accent-color:rgb(150,50%,255);}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
