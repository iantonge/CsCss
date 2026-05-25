using Xunit;

namespace CsCss.Tests.AtRules;

public class FontFaceTests
{
    [Fact]
    public void RendersFontFace()
    {
        Document document = new()
        {
            [FontFace] = new()
            {
                [FontFace.Family] = "Inter",
                [FontFace.Src] = FontFace.Url(Url("/fonts/inter.woff2")).Format("woff2"),
                [FontFace.Weight] = (100, 900),
                [FontFace.Style] = Normal,
                [FontFace.Display] = FontFace.Swap
            }
        };

        var expected = """
            @font-face {
                font-family: 'Inter';
                src: url('/fonts/inter.woff2') format('woff2');
                font-weight: 100 900;
                font-style: normal;
                font-display: swap;
            }
            """;

        Assert.Equal(expected, document.ToString());
    }

    [Fact]
    public void PreservesOrderWithStyleRules()
    {
        Document document = new()
        {
            [FontFace] = new()
            {
                [FontFace.Family] = "Inter",
                [FontFace.Src] = FontFace.Local("Inter")
            },
            [".card"] = new()
            {
                [Color] = Red
            }
        };

        var expected = """
            @font-face {
                font-family: 'Inter';
                src: local('Inter');
            }
            .card {
                color: red;
            }
            """;

        Assert.Equal(expected, document.ToString());
    }
}
