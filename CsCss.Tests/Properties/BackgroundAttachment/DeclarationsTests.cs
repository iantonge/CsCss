using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundAttachment;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundAttachment()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundAttachment] = Keywords.Scroll
        };

        Assert.Equal(".test{background-attachment:scroll;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
