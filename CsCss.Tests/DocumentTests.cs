using System.IO;
using CsCss.AtRules.Media;
using Xunit;
using static CsCss.AtRuleFunctions;

namespace CsCss.Tests;

public class DocumentTests
{
    [Fact]
    public void RendersEmptyDocument()
    {
        Document document = new();

        Assert.Equal(string.Empty, document.ToCssString());
    }

    [Fact]
    public void RendersDocument()
    {
        Document document = new ()
        {
            [".my-class"] = new ()
            {
                [Height] = 10.Px(),
                [Color] = Red
            }
        };

        var expected = """
            .my-class {
                height: 10px;
                color: red;
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void WritesDocumentToCssWriter()
    {
        Document document = new()
        {
            [".my-class"] = new()
            {
                [Height] = 10.Px()
            }
        };

        using StringWriter stringWriter = new();

        document.WriteTo(new CssWriter(stringWriter));

        var expected = """
            .my-class {
                height: 10px;
            }
            """;

        Assert.Equal(expected, stringWriter.ToString());
    }

    [Fact]
    public void RendersMinifiedEmptyDocument()
    {
        Document document = new();

        Assert.Equal(string.Empty, document.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void RendersMinifiedDocument()
    {
        Document document = new()
        {
            [".my-class"] = new()
            {
                [Height] = 10.Px(),
                [Color] = Red
            },
            [".other"] = new()
            {
                [Color] = Blue
            }
        };

        Assert.Equal(".my-class{height:10px;color:red;}.other{color:blue;}", document.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void RendersMinifiedNestedRules()
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

        Assert.Equal("@media (width >= 768px){@supports (color: red){.card{height:10px;}}}", document.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void RendersMinifiedKeyframes()
    {
        Document document = new()
        {
            [Keyframes, "fade-in"] = new()
            {
                [Keyframes.From] = new()
                {
                    [Color] = Red
                },
                [Keyframes.To] = new()
                {
                    [Color] = Blue
                }
            }
        };

        Assert.Equal("@keyframes fade-in{from{color:red;}to{color:blue;}}", document.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void RendersMinifiedDescriptorAtRules()
    {
        Document document = new()
        {
            [FontFace] = new()
            {
                [FontFace.Family] = "Inter",
                [FontFace.Src] = FontFace.Local("Inter")
            },
            [Property, "--brand-color"] = new()
            {
                [Property.Syntax] = Property.Color,
                [Property.Inherits] = false,
                [Property.InitialValue] = Red
            }
        };

        Assert.Equal("@font-face{font-family:'Inter';src:local('Inter');}@property --brand-color{syntax:\"<color>\";inherits:false;initial-value:red;}", document.ToCssString(CssFormatting.Minified));
    }

    [Fact]
    public void RendersMinifiedImports()
    {
        Document document = new()
        {
            [Import] = Import.Url(Url("/reset.css")),
            [Import] = Import.Url(Url("/theme.css")).Layer("theme").Media(MediaFeatures.Width >= 768.Px())
        };

        Assert.Equal("@import url('/reset.css');@import url('/theme.css') layer(theme) (width >= 768px);", document.ToCssString(CssFormatting.Minified));
    }
}
