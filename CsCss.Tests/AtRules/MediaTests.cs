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
            [Media, MediaQuery.Width >= 768.Px()] = new()
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
            [Media, MediaQuery.Width >= 768.Px()] = rules
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
}
