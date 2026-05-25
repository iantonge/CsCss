using CsCss.AtRules.Media;
using Xunit;
using static CsCss.AtRuleFunctions;

namespace CsCss.Tests.AtRules;

public class AtRuleFunctionsTests
{
    [Fact]
    public void RendersMediaRuleFunction()
    {
        Document document = new()
        {
            [Media(MediaFeatures.Width >= 768.Px())] = new()
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

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersSupportsRuleFunction()
    {
        Document document = new()
        {
            [Supports(new()
            {
                [Color] = Red
            })] = new()
            {
                [".card"] = new()
                {
                    [Height] = 10.Px()
                }
            }
        };

        var expected = """
            @supports (color: red) {
                .card {
                    height: 10px;
                }
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersNestedMediaAndSupportsRuleFunctions()
    {
        Document document = new()
        {
            [Media(MediaFeatures.Width >= 768.Px())] = new()
            {
                [Supports(new()
                {
                    [Color] = Red
                })] = new()
                {
                    [".card"] = new()
                    {
                        [Height] = 10.Px()
                    }
                }
            }
        };

        var expected = """
            @media (width >= 768px) {
                @supports (color: red) {
                    .card {
                        height: 10px;
                    }
                }
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersFluentSupportsOrCondition()
    {
        Document document = new()
        {
            [Supports(new()
            {
                [Color] = Red
            }).Or(new()
            {
                [Height] = 10.Px()
            })] = new()
            {
                [".card"] = new()
                {
                    [Color] = Blue
                }
            }
        };

        var expected = """
            @supports (color: red) or (height: 10px) {
                .card {
                    color: blue;
                }
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersGroupedFluentSupportsCondition()
    {
        Document document = new()
        {
            [Supports(new()
            {
                [Color] = Red
            }).And(
                Supports(new()
                {
                    [Height] = 10.Px()
                }).Or(new()
                {
                    [Color] = Blue
                })
            )] = new()
            {
                [".card"] = new()
                {
                    [Height] = 20.Px()
                }
            }
        };

        var expected = """
            @supports (color: red) and ((height: 10px) or (color: blue)) {
                .card {
                    height: 20px;
                }
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersLeftAssociativeFluentSupportsCondition()
    {
        var supports = Supports(new()
        {
            [Color] = Red
        }).And(new()
        {
            [Height] = 10.Px()
        }).Or(new()
        {
            [Color] = Blue
        });

        Assert.Equal("((color: red) and (height: 10px)) or (color: blue)", supports.ToString());
    }

    [Fact]
    public void RendersMediaFeatures()
    {
        Assert.Equal("(400px <= width <= 700px)", MediaFeatures.Width.Between(400.Px(), 700.Px()).ToString());
        Assert.Equal("screen", MediaFeatures.Screen.ToString());
        Assert.Equal("(hover: hover)", MediaFeatures.Hovered.ToString());
        Assert.Equal("(prefers-reduced-motion: no-preference)", MediaFeatures.PrefersReducedMotion.NoPreference.ToString());
    }
}
