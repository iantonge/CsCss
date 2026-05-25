using System;
using Xunit;

namespace CsCss.Tests.AtRules;

public class PropertyTests
{
    [Fact]
    public void RendersProperty()
    {
        Document document = new()
        {
            [Property, "--brand-color"] = new()
            {
                [Property.Syntax] = Property.Color,
                [Property.Inherits] = false,
                [Property.InitialValue] = Red
            }
        };

        var expected = """
            @property --brand-color {
                syntax: "<color>";
                inherits: false;
                initial-value: red;
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void PreservesOrderWithStyleRules()
    {
        Document document = new()
        {
            [Property, "--space"] = new()
            {
                [Property.Syntax] = Property.Length,
                [Property.Inherits] = true,
                [Property.InitialValue] = 0.Px()
            },
            [".card"] = new()
            {
                [Color] = Red
            }
        };

        var expected = """
            @property --space {
                syntax: "<length>";
                inherits: true;
                initial-value: 0px;
            }
            .card {
                color: red;
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Theory]
    [InlineData("")]
    [InlineData("-brand-color")]
    [InlineData("--")]
    [InlineData("--brand color")]
    public void RejectsInvalidPropertyNames(string name)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Document()
            {
                [Property, name] = new()
            };
        });
    }
}
