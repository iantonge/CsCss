using CsCss.AtRules.Media;
using Xunit;
using static CsCss.AtRuleFunctions;

namespace CsCss.Tests.AtRules;

public class MediaTests
{
    [Fact]
    public void RendersMediaRule()
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
            [Media(MediaFeatures.Width >= 768.Px())] = rules
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

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersAndMediaQuery()
    {
        var query = MediaFeatures.Screen & (MediaFeatures.Width >= 768.Px()) & MediaFeatures.Hovered;

        Assert.Equal("screen and (width >= 768px) and (hover: hover)", query.ToString());
    }

    [Fact]
    public void RendersCommaSeparatedMediaQueryList()
    {
        var query = MediaFeatures.Print | (MediaFeatures.Screen & (MediaFeatures.Width >= 768.Px()));

        Assert.Equal("print, screen and (width >= 768px)", query.ToString());
    }

    [Fact]
    public void RendersNegatedMediaQuery()
    {
        var query = !MediaFeatures.Print;

        Assert.Equal("not print", query.ToString());
    }

    [Fact]
    public void RendersCommonMediaFeatures()
    {
        Assert.Equal("all", MediaFeatures.All.ToString());
        Assert.Equal("screen", MediaFeatures.Screen.ToString());
        Assert.Equal("print", MediaFeatures.Print.ToString());
        Assert.Equal("(hover: none)", MediaFeatures.NoHover.ToString());
        Assert.Equal("(pointer: fine)", MediaFeatures.FinePointer.ToString());
        Assert.Equal("(prefers-reduced-motion: reduce)", MediaFeatures.ReducedMotion.ToString());
        Assert.Equal("(orientation: landscape)", MediaFeatures.Landscape.ToString());
    }

    [Fact]
    public void RendersComposedMediaRule()
    {
        Document document = new()
        {
            [Media(MediaFeatures.Screen & (MediaFeatures.Width >= 768.Px()) & MediaFeatures.Hovered)] = new()
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

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersEqualityMediaQuery()
    {
        var query = MediaFeatures.Width == 768.Px();

        Assert.Equal("(width = 768px)", query.ToString());
    }

    [Fact]
    public void RendersTwoSidedRangeMediaQuery()
    {
        var query = MediaFeatures.Width.Between(400.Px(), 700.Px());

        Assert.Equal("(400px <= width <= 700px)", query.ToString());
    }

    [Fact]
    public void RendersBooleanMediaFeature()
    {
        MediaQuery query = MediaFeatures.Color;

        Assert.Equal("(color)", query.ToString());
    }

    [Fact]
    public void RendersIntegerRangeMediaFeature()
    {
        var query = MediaFeatures.Color >= 8;

        Assert.Equal("(color >= 8)", query.ToString());
    }

    [Fact]
    public void RendersDiscreteMediaFeature()
    {
        Assert.Equal("(orientation: portrait)", MediaFeatures.Orientation.Portrait.ToString());
        Assert.Equal("(hover: hover)", MediaFeatures.Hover.Hover.ToString());
        Assert.Equal("(pointer: coarse)", MediaFeatures.Pointer.Coarse.ToString());
        Assert.Equal("(prefers-reduced-motion: no-preference)", MediaFeatures.PrefersReducedMotion.NoPreference.ToString());
    }

    [Fact]
    public void RendersAdditionalDiscreteMediaFeatures()
    {
        Assert.Equal("(any-hover: none)", MediaFeatures.AnyHover.None.ToString());
        Assert.Equal("(any-pointer: fine)", MediaFeatures.AnyPointer.Fine.ToString());
        Assert.Equal("(color-gamut: rec2020)", MediaFeatures.ColorGamut.Rec2020.ToString());
        Assert.Equal("(display-mode: minimal-ui)", MediaFeatures.DisplayMode.MinimalUi.ToString());
        Assert.Equal("(dynamic-range: high)", MediaFeatures.DynamicRange.High.ToString());
        Assert.Equal("(environment-blending: additive)", MediaFeatures.EnvironmentBlending.Additive.ToString());
        Assert.Equal("(forced-colors: active)", MediaFeatures.ForcedColors.Active.ToString());
        Assert.Equal("(inverted-colors: inverted)", MediaFeatures.InvertedColors.Inverted.ToString());
        Assert.Equal("(nav-controls: back)", MediaFeatures.NavControls.Back.ToString());
        Assert.Equal("(overflow-block: optional-paged)", MediaFeatures.OverflowBlock.OptionalPaged.ToString());
        Assert.Equal("(overflow-inline: scroll)", MediaFeatures.OverflowInline.Scroll.ToString());
        Assert.Equal("(prefers-color-scheme: dark)", MediaFeatures.PrefersColorScheme.Dark.ToString());
        Assert.Equal("(prefers-contrast: more)", MediaFeatures.PrefersContrast.More.ToString());
        Assert.Equal("(prefers-reduced-data: reduce)", MediaFeatures.PrefersReducedData.Reduce.ToString());
        Assert.Equal("(prefers-reduced-transparency: no-preference)", MediaFeatures.PrefersReducedTransparency.NoPreference.ToString());
        Assert.Equal("(scan: progressive)", MediaFeatures.Scan.Progressive.ToString());
        Assert.Equal("(scripting: initial-only)", MediaFeatures.Scripting.InitialOnly.ToString());
        Assert.Equal("(update: fast)", MediaFeatures.Update.Fast.ToString());
        Assert.Equal("(video-color-gamut: p3)", MediaFeatures.VideoColorGamut.P3.ToString());
        Assert.Equal("(video-dynamic-range: standard)", MediaFeatures.VideoDynamicRange.Standard.ToString());
    }
}
