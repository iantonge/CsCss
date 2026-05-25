using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundPosition;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundColor()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundPosition] = 10.Px()
        };

        Assert.Equal(".test{background-position:10px;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
