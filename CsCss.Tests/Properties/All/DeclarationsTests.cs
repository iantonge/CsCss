using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.All;

public class DeclarationsTests
{
    [Fact]
    public void CanSetAll()
    {
        var declarations = new Declarations()
        {
            [Keywords.All] = Unset
        };

        Assert.Equal(".test{all:unset;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
