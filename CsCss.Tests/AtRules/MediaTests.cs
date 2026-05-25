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

        Assert.Equal(expected, document.ToCssString());
    }

    [Fact]
    public void RendersAndMediaQuery()
    {
        var query = Media.Screen & (Media.Width >= 768.Px()) & Media.Hovered;

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
        Assert.Equal("(pointer: fine)", Media.FinePointer.ToString());
        Assert.Equal("(prefers-reduced-motion: reduce)", Media.ReducedMotion.ToString());
        Assert.Equal("(orientation: landscape)", Media.Landscape.ToString());
    }

    [Fact]
    public void RendersComposedMediaRule()
    {
        Document document = new()
        {
            [Media, Media.Screen & (Media.Width >= 768.Px()) & Media.Hovered] = new()
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
        var query = Media.Width == 768.Px();

        Assert.Equal("(width = 768px)", query.ToString());
    }

    [Fact]
    public void RendersTwoSidedRangeMediaQuery()
    {
        var query = Media.Width.Between(400.Px(), 700.Px());

        Assert.Equal("(400px <= width <= 700px)", query.ToString());
    }

    [Fact]
    public void RendersBooleanMediaFeature()
    {
        MediaQuery query = Media.Color;

        Assert.Equal("(color)", query.ToString());
    }

    [Fact]
    public void RendersIntegerRangeMediaFeature()
    {
        var query = Media.Color >= 8;

        Assert.Equal("(color >= 8)", query.ToString());
    }

    [Fact]
    public void RendersDiscreteMediaFeature()
    {
        Assert.Equal("(orientation: portrait)", Media.Orientation.Portrait.ToString());
        Assert.Equal("(hover: hover)", Media.Hover.Hover.ToString());
        Assert.Equal("(pointer: coarse)", Media.Pointer.Coarse.ToString());
        Assert.Equal("(prefers-reduced-motion: no-preference)", Media.PrefersReducedMotion.NoPreference.ToString());
    }

    [Fact]
    public void RendersAdditionalDiscreteMediaFeatures()
    {
        Assert.Equal("(any-hover: none)", Media.AnyHover.None.ToString());
        Assert.Equal("(any-pointer: fine)", Media.AnyPointer.Fine.ToString());
        Assert.Equal("(color-gamut: rec2020)", Media.ColorGamut.Rec2020.ToString());
        Assert.Equal("(display-mode: minimal-ui)", Media.DisplayMode.MinimalUi.ToString());
        Assert.Equal("(dynamic-range: high)", Media.DynamicRange.High.ToString());
        Assert.Equal("(environment-blending: additive)", Media.EnvironmentBlending.Additive.ToString());
        Assert.Equal("(forced-colors: active)", Media.ForcedColors.Active.ToString());
        Assert.Equal("(inverted-colors: inverted)", Media.InvertedColors.Inverted.ToString());
        Assert.Equal("(nav-controls: back)", Media.NavControls.Back.ToString());
        Assert.Equal("(overflow-block: optional-paged)", Media.OverflowBlock.OptionalPaged.ToString());
        Assert.Equal("(overflow-inline: scroll)", Media.OverflowInline.Scroll.ToString());
        Assert.Equal("(prefers-color-scheme: dark)", Media.PrefersColorScheme.Dark.ToString());
        Assert.Equal("(prefers-contrast: more)", Media.PrefersContrast.More.ToString());
        Assert.Equal("(prefers-reduced-data: reduce)", Media.PrefersReducedData.Reduce.ToString());
        Assert.Equal("(prefers-reduced-transparency: no-preference)", Media.PrefersReducedTransparency.NoPreference.ToString());
        Assert.Equal("(scan: progressive)", Media.Scan.Progressive.ToString());
        Assert.Equal("(scripting: initial-only)", Media.Scripting.InitialOnly.ToString());
        Assert.Equal("(update: fast)", Media.Update.Fast.ToString());
        Assert.Equal("(video-color-gamut: p3)", Media.VideoColorGamut.P3.ToString());
        Assert.Equal("(video-dynamic-range: standard)", Media.VideoDynamicRange.Standard.ToString());
    }
}
