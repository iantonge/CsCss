using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.AlignSelf;

public class DeclarationsTests
{
    [Fact]
    public void CanSetAlignSelf()
    {
        var declarations = new Declarations()
        {
            [Keywords.AlignSelf] = Normal
        };

        Assert.Equal(".test{align-self:normal;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
