using CsCss.AtRules.Media;
using Xunit;
using static CsCss.AtRuleFunctions;

namespace CsCss.Tests.AtRules;

public class SupportsTests
{
    [Fact]
    public void RendersSupportsRule()
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
    public void RendersSupportsRuleInsideMediaRule()
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
}
