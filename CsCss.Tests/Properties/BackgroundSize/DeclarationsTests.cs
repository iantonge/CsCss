using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundSize;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundSize()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundSize] = Keywords.Contain
        };

        Assert.Equal(".test{background-size:contain;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
