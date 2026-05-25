using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.Height;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundColor()
    {
        var declarations = new Declarations()
        {
            [Keywords.Height] = 10.Px()
        };

        Assert.Equal(".test{height:10px;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
