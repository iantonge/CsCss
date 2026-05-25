using System;
using Xunit;

namespace CsCss.Tests.AtRules;

public class KeyframesTests
{
    [Fact]
    public void RendersKeyframes()
    {
        Document document = new()
        {
            [Keyframes, "fade-in"] = new()
            {
                [From] = new()
                {
                    [Color] = Red
                },
                [50.Percent()] = new()
                {
                    [Color] = Blue
                },
                [To] = new()
                {
                    [Color] = Red
                }
            }
        };

        var expected = """
            @keyframes fade-in {
                from {
                    color: red;
                }
                50% {
                    color: blue;
                }
                to {
                    color: red;
                }
            }
            """;

        Assert.Equal(expected, document.ToString());
    }

    [Fact]
    public void PreservesOrderWithStyleRules()
    {
        Document document = new()
        {
            [".before"] = new()
            {
                [Color] = Blue
            },
            [Keyframes, "fade-in"] = new()
            {
                [From] = new()
                {
                    [Color] = Red
                }
            },
            [".after"] = new()
            {
                [Color] = Red
            }
        };

        var expected = """
            .before {
                color: blue;
            }
            @keyframes fade-in {
                from {
                    color: red;
                }
            }
            .after {
                color: red;
            }
            """;

        Assert.Equal(expected, document.ToString());
    }

    [Fact]
    public void RejectsCalculatedKeyframePercentage()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new CsCss.AtRules.Keyframes.Keyframes()
            {
                [Functions.Calc(50.Percent() + 10.Percent())] = new()
            };
        });
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(101)]
    public void RejectsOutOfRangeKeyframePercentage(int percentage)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            _ = new CsCss.AtRules.Keyframes.Keyframes()
            {
                [percentage.Percent()] = new()
            };
        });
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("none")]
    [InlineData("1fade")]
    [InlineData("fade in")]
    public void RejectsInvalidKeyframesNames(string name)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Document()
            {
                [Keyframes, name] = new()
            };
        });
    }
}
