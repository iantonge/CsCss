using System.Linq;
using Xunit;

namespace CsCss.Tests.Properties.Border;

public class DeclarationsTests
{
    [Fact]
    public void CanSetBorder()
    {
        var declarations = new Declarations()
        {
            [Keywords.Border] = Red
        };

        Assert.Equal(".test{border:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderTop()
    {
        var declarations = new Declarations()
        {
            [BorderTop] = Red
        };

        Assert.Equal(".test{border-top:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderBottom()
    {
        var declarations = new Declarations()
        {
            [BorderBottom] = Red
        };

        Assert.Equal(".test{border-bottom:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderLeft()
    {
        var declarations = new Declarations()
        {
            [BorderLeft] = Red
        };

        Assert.Equal(".test{border-left:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void CanSetBorderRight()
    {
        var declarations = new Declarations()
        {
            [BorderRight] = Red
        };

        Assert.Equal(".test{border-right:red;}", new Document { [".test"] = declarations }.ToCssString(CssFormatting.Minified));
    }
}
