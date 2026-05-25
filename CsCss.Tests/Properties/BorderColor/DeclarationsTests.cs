using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.BorderColor;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBorderColor()
    {
        var declarations = new Declarations()
        {
            [Keywords.BorderColor] = Red
        };

        Assert.Equal(".test{border-color:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderTop()
    {
        var declarations = new Declarations()
        {
            [BorderTopColor] = Red
        };

        Assert.Equal(".test{border-top-color:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderBottom()
    {
        var declarations = new Declarations()
        {
            [BorderBottomColor] = Red
        };

        Assert.Equal(".test{border-bottom-color:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderLeft()
    {
        var declarations = new Declarations()
        {
            [BorderLeftColor] = Red
        };

        Assert.Equal(".test{border-left-color:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderRight()
    {
        var declarations = new Declarations()
        {
            [BorderRightColor] = Red
        };

        Assert.Equal(".test{border-right-color:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
