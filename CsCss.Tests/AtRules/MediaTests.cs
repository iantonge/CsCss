using CsCss.AtRules.Media;
using Xunit;

namespace CsCss.Tests.AtRules;

public class MediaTests
{
    [Fact]
    public void RendersMediaRule()
    {
        Document document = new()
        {
            [Media, Media.Width >= 768.Px()] = new()
            {
                [".card"] = new()
                {
                    [Height] = 20.Px()
                }
            }
        };

        var expected = """
            @media (width >= 768px) {
                .card {
                    height: 20px;
                }
            }
            """;

        Assert.Equal(expected, document.ToString());
    }

    [Fact]
    public void NestedRuleListUsesStyleRuleSyntax()
    {
        RuleList rules = new()
        {
            [".card"] = new()
            {
                [Color] = Red
            },
            [".title"] = new()
            {
                [Color] = Blue
            }
        };

        Document document = new()
        {
            [Media, Media.Width >= 768.Px()] = rules
        };

        var expected = """
            @media (width >= 768px) {
                .card {
                    color: red;
                }
                .title {
                    color: blue;
                }
            }
            """;

        Assert.Equal(expected, document.ToString());
    }

    [Fact]
    public void RendersAndMediaQuery()
    {
        var query = Media.Screen & (Media.Width >= 768.Px()) & Media.Hover;

        Assert.Equal("screen and (width >= 768px) and (hover: hover)", query.ToString());
    }

    [Fact]
    public void RendersCommaSeparatedMediaQueryList()
    {
        var query = Media.Print | (Media.Screen & (Media.Width >= 768.Px()));

        Assert.Equal("print, screen and (width >= 768px)", query.ToString());
    }

    [Fact]
    public void RendersNegatedMediaQuery()
    {
        var query = !Media.Print;

        Assert.Equal("not print", query.ToString());
    }

    [Fact]
    public void RendersCommonMediaFeatures()
    {
        Assert.Equal("all", Media.All.ToString());
        Assert.Equal("screen", Media.Screen.ToString());
        Assert.Equal("print", Media.Print.ToString());
        Assert.Equal("(hover: none)", Media.NoHover.ToString());
        Assert.Equal("(pointer: fine)", Media.Pointer.ToString());
        Assert.Equal("(prefers-reduced-motion: reduce)", Media.ReducedMotion.ToString());
        Assert.Equal("(orientation: landscape)", Media.Landscape.ToString());
    }

    [Fact]
    public void RendersComposedMediaRule()
    {
        Document document = new()
        {
            [Media, Media.Screen & (Media.Width >= 768.Px()) & Media.Hover] = new()
            {
                [".card"] = new()
                {
                    [Height] = 20.Px()
                }
            }
        };

        var expected = """
            @media screen and (width >= 768px) and (hover: hover) {
                .card {
                    height: 20px;
                }
            }
            """;

        Assert.Equal(expected, document.ToString());
    }
}
