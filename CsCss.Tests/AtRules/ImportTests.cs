using System;
using Xunit;

namespace CsCss.Tests.AtRules;

public class ImportTests
{
    [Fact]
    public void RendersImport()
    {
        Document document = new()
        {
            [Import] = Import.Url(Url("/reset.css"))
        };

        Assert.Equal("@import url('/reset.css');", document.ToCssString());
    }

    [Fact]
    public void RendersImportWithLayerAndMedia()
    {
        Document document = new()
        {
            [Import] = Import.Url(Url("/theme.css")).Layer("theme").Media(Media.Width >= 768.Px())
        };

        Assert.Equal("@import url('/theme.css') layer(theme) (width >= 768px);", document.ToCssString());
    }

    [Fact]
    public void AllowsImportsBeforeStyleRules()
    {
        Document document = new()
        {
            [Import] = Import.Url(Url("/reset.css")),
            [Import] = Import.Url(Url("/theme.css")).Layer(),
            [".card"] = new()
            {
                [Color] = Red
            }
        };

        var expected = """
            @import url('/reset.css');
            @import url('/theme.css') layer;
            .card {
                color: red;
            }
            """;

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RejectsImportsAfterStyleRules()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            _ = new Document()
            {
                [".card"] = new()
                {
                    [Color] = Red
                },
                [Import] = Import.Url(Url("/late.css"))
            };
        });
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("1theme")]
    [InlineData("theme layer")]
    public void RejectsInvalidLayerNames(string name)
    {
        Assert.Throws<ArgumentException>(() => Import.Layer(name));
    }
}
