using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundOrigin;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundOriginFromKeyword()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundOrigin] = BorderBox
        };

        Assert.Equal(".test{background-origin:border-box;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
