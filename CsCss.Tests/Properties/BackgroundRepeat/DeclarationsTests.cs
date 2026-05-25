using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundRepeat;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBackgroundRepeatFromKeyword()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundRepeat] = Repeat
        };

        Assert.Equal(".test{background-repeat:repeat;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBackgroundRepeatFromTuple()
    {
        var declarations = new Declarations()
        {
            [Keywords.BackgroundRepeat] = (Space, NoRepeat)
        };

        Assert.Equal(".test{background-repeat:space no-repeat;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
