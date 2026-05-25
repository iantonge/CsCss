using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundImage;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundImageFromKeyword()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundRepeat] = Keywords.Repeat
        };

        Assert.Equal(".test{background-repeat:repeat;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBackgroundRepeatFromTuple()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundRepeat] = (Keywords.Space, Keywords.NoRepeat)
        };

        Assert.Equal(".test{background-repeat:space no-repeat;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
